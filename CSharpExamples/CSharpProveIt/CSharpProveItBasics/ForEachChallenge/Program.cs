namespace ForEachChallenge;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Solution: ");
        Solution();
        Console.WriteLine("\nBonus Solution: ");
        Bonus();
    }

    private static void Solution()
    {
        List<string> people = new()
        {
            "Kyle Example",
            "Sam Person",
            "Sally FromThaBlock",
            "Frank Sample",
            "Bob Dirk"
        };

        foreach (var name in people)
        {
            Console.WriteLine(name);
        }
    }

    private static void Bonus()
    {
        var people = new List<Person>()
        {
            new Person()
            {
                FirstName = "Kyle",
                LastName = "Example"
            },
            new Person()
            {
                FirstName = "Sam",
                LastName = "Person"
            },
            new Person()
            {
                FirstName = "Sally",
                LastName = "FromThaBlock"
            },
            new Person()
            {
                FirstName = "Frank",
                LastName = "Sample"
            },
            new Person()
            {
                FirstName = "Bob",
                LastName = "Dirk"
            }
        };

        foreach (var person in people)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }


    public class Person
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
