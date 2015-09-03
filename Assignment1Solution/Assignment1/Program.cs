namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            int age;
            int heightFeet;

            bool isCitizen;
            bool canVote;

            double heightInches;
            double totalHeightCM;



            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("Your full name is " + firstName + " " + middleInitial + " " + lastName + ".");
            fullName = System.Console.ReadLine();




        }
    }
}
