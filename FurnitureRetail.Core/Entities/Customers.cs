
namespace FurnitureRetail.Core;

public class Customers : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateOnly RegistrationDate { get; set; }
    public int NumberOfSelledProducts { get; set; }
}

