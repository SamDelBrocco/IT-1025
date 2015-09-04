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



            System.Console.Write("What is your height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height in feet are you? ");
            heightInches = int.Parse(System.Console.ReadLine());

            System.Console.Write("Your total height in CM is " + ((heightFeet * 12) + (heightInches * 2.54)));
            totalHeightCM = double.Parse(System.Console.ReadLine());



            System.Console.WriteLine("What is your age? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("T or F: I am a US Citizen? ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            bool OK;
            OK = ((age >= 18) && (isCitizen = true));
            canVote = OK == true;

            System.Console.WriteLine(fullName + " can vote.");
            canVote = bool.Parse(System.Console.ReadLine());


            
        }
    }
}
