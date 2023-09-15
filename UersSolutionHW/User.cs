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

        public override string ToString()
        {
            return Age < 10 ? $"Hi, my name is {FirstName} and last name {Lastname}." +
                              $"I am baby. I am {UserGender}."
                            :
                              $"Hi, my name is {FirstName} and last name {Lastname}." +
                              $"I am {Age} years old. I am {UserGender}.";

        }
    }
}
