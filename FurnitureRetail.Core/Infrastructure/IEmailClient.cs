namespace FurnitureRetail.Core;

public interface IEmailClient
{
    Task Send(string to, string subject, string body);
}