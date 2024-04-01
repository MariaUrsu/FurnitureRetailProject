using MediatR;

namespace FurnitureRetail.Core;
public class CustomerByIdQuery : Query, IRequest<Result<CustomerModel>>
{
    public Guid Id { get; set; }
}

public class CustomerByIdHandler : IRequestHandler<CustomerByIdQuery, Result<CustomerModel>>
{
    private readonly IReadEntities _readEntities;

    public CustomerByIdHandler(IReadEntities readEntities)
    {
        _readEntities = readEntities;
    }

    public async Task<Result<CustomerModel>> Handle(CustomerByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _readEntities.Get<Customers>(request.Id);
        if (user == null)
        {
            return Result.NotPresent;
        }

        return new CustomerModel
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            RegistrationDate = user.RegistrationDate,
            NumberOfSelledProducts = user.NumberOfSelledProducts
        };
    }
}
