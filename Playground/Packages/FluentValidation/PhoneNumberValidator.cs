using FluentValidation;

namespace LearningPlace.Packages.FluentValidation;

public class PhoneNumberValidator :  AbstractValidator<PhoneNumber>
{
    public PhoneNumberValidator()
    {
        //This rule will only run
        //WHEN number Starts with '1'
        //AND
        //WHEN Number Ends with '1'
        RuleFor(x => x.Number)
            .MinimumLength(3)
            .When(x => x.Number.StartsWith("1"))
            .When(x => x.Number.EndsWith("1"))
            .WithSeverity(Severity.Info);
    }

    public static void PhoneNumberValidatorTest()
    {
        var phoneNumber = new PhoneNumber
        {
            Number = "01"
        };
        var phoneValidator = new PhoneNumberValidator();
        var isValidated = phoneValidator.Validate(phoneNumber);
        Console.WriteLine(isValidated.IsValid);
    }
}