
using FurnitureRetail.Core.Queries;
using FurnitureRetail.Core.Utils.Extensions;
using MediatR;

namespace FurnitureRetail.Core;

public class CreateProductCommand : Command, IRequest<Result<ProductModel>>
{
    public string Name { get; set; }
    public double Price { get; set; }
}

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Result<ProductModel>>
{
    private readonly IWriteEntities _writeEntities;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductHandler(IWriteEntities writeEntities, IUnitOfWork unitOfWork)
    {
        _writeEntities = writeEntities;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<ProductModel>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var user = new Products
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Price = request.Price,
        };
        
        _writeEntities.Add(user);
        await _unitOfWork.Save();

        return new ProductModel
        {
            Id = user.Id,
            Name = user.Name,
            Price = user.Price
        };
    }
}