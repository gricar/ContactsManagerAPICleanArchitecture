using ContactsManagerAPI.Domain.Entities;
using ContactsManagerAPI.Domain.Interfaces;

namespace ContactsManagerAPI.Application.ContactsManager.Commands.CreateNewContact;

public class CreateNewContactCommandHandler : IRequestHandler<CreateNewContactCommand, Guid>
{
    private readonly IContactRepository _contactRepository;

    public CreateNewContactCommandHandler(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task<Guid> Handle(CreateNewContactCommand request, CancellationToken cancellationToken)
    {
        var entity = new Contact(request.Name, request.DDDCode, request.Phone, request.Email);

         await _contactRepository.AddAsync(entity, cancellationToken);

        return entity.Id;
    }
}
