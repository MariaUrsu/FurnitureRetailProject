using MediatR;

namespace FurnitureRetail.Core.Queries
{
    public class CustomerListQuery : Query, IRequest<Result<IReadOnlyCollection<Customers>>> { }

    public class CustomerListHandler : IRequestHandler<CustomerListQuery, Result<IReadOnlyCollection<Customers>>>
    {
        private readonly IReadEntities _readEntities;

        public CustomerListHandler(IReadEntities readEntities)
        {
            _readEntities = readEntities;
        }

        public async Task<Result<IReadOnlyCollection<Customers>>> Handle(CustomerListQuery request, CancellationToken cancellationToken)
        {
            var users = await _readEntities.Get<Customers>();
            if (users == null)
            {
                return Result.NotPresent;
            }

            return users.ToList();
        }
    }

}
