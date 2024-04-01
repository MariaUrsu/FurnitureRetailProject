using MediatR;

namespace FurnitureRetail.Core;
public class ProductByIdQuery : Query, IRequest<Result<ProductModel>>
{
    public Guid Id { get; set; }
}

public class ProductByIdHandler : IRequestHandler<ProductByIdQuery, Result<ProductModel>>
{
    private readonly IReadEntities _readEntities;

    public ProductByIdHandler(IReadEntities readEntities)
    {
        _readEntities = readEntities;
    }

    public async Task<Result<ProductModel>> Handle(ProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _readEntities.Get<Products>(request.Id);
        if (product == null)
        {
            return Result.NotPresent;
        }

        return new ProductModel
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        };
    }
}
