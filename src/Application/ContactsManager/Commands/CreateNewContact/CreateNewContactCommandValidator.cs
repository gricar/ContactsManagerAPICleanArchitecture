namespace ContactsManagerAPI.Application.ContactsManager.Commands.CreateNewContact;

public class CreateNewContactCommandValidator : AbstractValidator<CreateNewContactCommand>
{
    public CreateNewContactCommandValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty();

        RuleFor(c => c.DDDCode)
            .NotEmpty()
            .Length(2);

        RuleFor(c => c.Phone)
            .NotEmpty()
            .Length(9);

        RuleFor(c => c.Email)
            .NotEmpty()
            .EmailAddress();
    }
}
