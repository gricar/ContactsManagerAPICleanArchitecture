namespace ContactsManagerAPI.Domain.Interfaces;
public interface IContactRepository
{
    Task AddAsync(Contact contact, CancellationToken cancellationToken);
}
