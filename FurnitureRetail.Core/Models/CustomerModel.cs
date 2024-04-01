namespace FurnitureRetail.Core;
public class CustomerModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateOnly RegistrationDate { get; set; }
    public int NumberOfSelledProducts { get; set; }
}