using FurnitureRetail.Core;

namespace FurnitureRetail.Infrastructure;

public class EmailClient : IEmailClient
{
    public Task Send(string to, string subject, string body)
    {
        throw new NotImplementedException();
    }
}