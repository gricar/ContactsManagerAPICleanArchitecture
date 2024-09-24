using ContactsManagerAPI.Domain.Entities;
using ContactsManagerAPI.Domain.Interfaces;
using ContactsManagerAPI.Infrastructure.Data;

namespace ContactsManagerAPI.Infrastructure.Repositories;
public class ContactRepository : IContactRepository
{
    private readonly ApplicationDbContext _context;

    public ContactRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Contact contact, CancellationToken cancellationToken)
    {
        await _context.Contacts.AddAsync(contact, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
