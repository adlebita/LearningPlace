namespace LearningPlace.Packages.FluentValidation;

public class Person
{
    public IEnumerable<PhoneNumber> PhoneNumbers { get; set; }
    public string Name { get; set; }

    public Person(IEnumerable<PhoneNumber> phoneNumbers, string name)
    {
        Name = name;
        PhoneNumbers = phoneNumbers;
    }
}

