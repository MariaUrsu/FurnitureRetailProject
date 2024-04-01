using MediatR;

namespace FurnitureRetail.Core.Queries
{
    public class ProductsListQuery : Query, IRequest<Result<IReadOnlyCollection<Products>>> { }

    public class ProductsListHandler : IRequestHandler<ProductsListQuery, Result<IReadOnlyCollection<Products>>>
    {
        private readonly IReadEntities _readEntities;

        public ProductsListHandler(IReadEntities readEntities)
        {
            _readEntities = readEntities;
        }

        public async Task<Result<IReadOnlyCollection<Products>>> Handle(ProductsListQuery request, CancellationToken cancellationToken)
        {
            var products = await _readEntities.Get<Products>();
            if (products == null)
            {
                return Result.NotPresent;
            }

            return products.ToList();
        }
    }

}
