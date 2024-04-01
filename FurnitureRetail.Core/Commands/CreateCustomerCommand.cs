
using FurnitureRetail.Core.Queries;
using FurnitureRetail.Core.Utils.Extensions;
using MediatR;

namespace FurnitureRetail.Core;

public class CreateCustomerCommand : Command, IRequest<Result<CustomerModel>>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public DateOnly RegistrationDate { get; set; }
    public int NumberOfSelledProducts { get; set; } = 0;
}

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Result<CustomerModel>>
{
    private readonly IWriteEntities _writeEntities;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCustomerHandler(IWriteEntities writeEntities, IUnitOfWork unitOfWork)
    {
        _writeEntities = writeEntities;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<CustomerModel>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var user = new Customers
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Password = request.Password.ComputeSha256Hash(),
            RegistrationDate = request.RegistrationDate,
            NumberOfSelledProducts = request.NumberOfSelledProducts
        };
        
        _writeEntities.Add(user);
        await _unitOfWork.Save();

        return new CustomerModel
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            RegistrationDate = user.RegistrationDate,
            NumberOfSelledProducts  = user.NumberOfSelledProducts
        };
    }
}