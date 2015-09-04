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

            fullName = firstName + middleInitial + lastName

            System.Console.WriteLine("Your full name is " + fullName + ".");
            fullName = System.Console.ReadLine();

            /////////

            System.Console.Write("What is your height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height in feet are you? ");
            heightInches = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Your total height is " + ((heightFeet * 12)+(heightInches * 2.54)));
            totalHeightCM = int.Parse(System.Console.ReadLine());


        }
    }
}
