namespace ContactsManagerAPI.Domain.Entities;
/*public class Contact
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string DDDCode { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public string? Email { get; private set; }
}*/

public record Contact(
    Guid Id,
    string Name,
    string DDDCode,
    string Phone,
    string? Email = null
)
{
    public Contact(string name, string DDDCode, string Phone, string? email = null)
        : this(Guid.NewGuid(), name, DDDCode, Phone, email)
    { }
}
