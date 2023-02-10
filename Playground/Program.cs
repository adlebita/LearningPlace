// See https://aka.ms/new-console-template for more information

// var phoneNumber = new PhoneNumber()
// {
//     Number = "01"
// };
// var phoneValidator = new PhoneNumberValidator();
// var isValidated = phoneValidator.Validate(phoneNumber);
// // Console.WriteLine(isValidated.IsValid);

// // Create an expression using expression lambda
// Expression<Func<int, int, int>> expression = (num1, num2) => num1 + num2;
//
// // Compile the expression
// var compiledExpression = expression.Compile();
//
// // Execute the expression. 
// var result = compiledExpression(3, 4);

//Delegates

using Microsoft.AspNetCore.Http.Extensions;

namespace LearningPlace;

//This type is delegate method. It takes any method, that takes an int and returns a boolean.
delegate bool Gauntlet(int x);

class Program
{
    //Use of delegates, allows code to be passed around. E.g. Can change conditions see below example.

    static bool GreaterThanFive(int x) => x > 5;
    static bool LessThanFive(int x) => x < 5;
    static int[] numberlist = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

    public static void Main(string[] args)
    {
        var query = new QueryBuilder
        {
            {"locationId", $"{123}"}, {"locationType", $"{456}"}
        };

        var acceptPicaUrl = new UriBuilder
        {
            
            Scheme = "https://dev-portal.cdcms.nz/",
            Path = "external/accept-pica",
            Query = query.ToString()
        };

        Console.WriteLine(acceptPicaUrl.ToString());
    }

    public static void PrintExceptions(string exception)
    {
    }


    public static void TestLambda(int number) => Console.WriteLine(number);

    public static bool TestLambda2(int number) => number > 2;


    public static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, Gauntlet gauntlet)
    {
        foreach (var number in numbers)
        {
            if (gauntlet(number))
            {
                yield return number;
            }
        }
    }

    //Func are delegate types. Here this func is pointing to an lambda expression. But in compiler sense, it's creating a method.
    //Generally no side effects are created with Func. Think Haskell.
    private static readonly Func<int, int> Add = i => i + 10;
}