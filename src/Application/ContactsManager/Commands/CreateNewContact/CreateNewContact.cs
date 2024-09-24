namespace ContactsManagerAPI.Application.ContactsManager.Commands.CreateNewContact;

public sealed record CreateNewContactCommand : IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string DDDCode { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
