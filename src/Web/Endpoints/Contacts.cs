using ContactsManagerAPI.Application.ContactsManager.Commands.CreateNewContact;

namespace ContactsManagerAPI.Web.Endpoints;

public class Contacts : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapPost(CreateContact);
    }

    public Task<Guid> CreateContact(ISender sender, CreateNewContactCommand command)
    {
        return sender.Send(command);
    }
}
