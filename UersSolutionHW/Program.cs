using UersSolutionHW;

public class Program
{
    private static void Main(string[] args)
    {
        string firstName = GetFirstName();
        string lastName = GetLastName();
        Gender gender = GetGender();

        User user1 = new User(20)
        {
            FirstName = firstName,
            Lastname = lastName,
            UserGender = gender
        };

        Console.WriteLine(user1.ToString());
    }

    public static Gender GetGender()
    {
        Console.WriteLine("Enrer your gender: Male or Female: ");
        string gender = Console.ReadLine().ToLower();

        while (gender != "male" && gender != "female")
        {
            Console.WriteLine("Enter your gender: Male or Female");
            gender = Console.ReadLine();
        }

        return gender == "male" ? Gender.Male : Gender.Female;
    }

    public static string GetFirstName()
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();

        return GetName(firstName);
    }

    public static string GetLastName()
    {
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        return GetName(lastName);
    }

    private static string GetName(string name)
    {
        while (int.TryParse(name, out int result) || string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("first/last name cannot be empty or contain numbers.");
            Console.WriteLine("Enter first/last name: ");
            name = Console.ReadLine();
        }

        return name;
    }
}
