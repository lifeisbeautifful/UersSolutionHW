namespace UersSolutionHW
{
    public enum Gender
    {
        Male,
        Female
    }

    public class User
    {
        public string FirstName { get; init; }
        public string Lastname { get; init; }
        public int Age { get; init; }
        public Gender UserGender { get; set; }

        public User() { }
        public User(int age)
        {
            Age = age;
        }
    }
}
