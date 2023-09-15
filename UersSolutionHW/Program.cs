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

        while (int.TryParse(firstName, out int result) || string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("first name cannot be empty or contain numbers.");
            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
        }

        return firstName;
    }

    public static string GetLastName()
    {
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        while (int.TryParse(lastName, out int result) || string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("last name cannot be empty or contain numbers.");
            Console.WriteLine("Enter last name: ");
            lastName = Console.ReadLine();
        }

        return lastName;
    }
}
