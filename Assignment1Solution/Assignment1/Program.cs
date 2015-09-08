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

            System.Console.Write("What is your height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height in feet are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            System.Console.Write("What is your age? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("True or False: I am a US Citizen? ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            fullName = firstName + " " + middleInitial + " " + lastName ;
            canVote = (age >= 18) && isCitizen && true;
            totalHeightCM = ((heightFeet * 12) + (heightInches * 2.54));


            System.Console.WriteLine("Your full name is " + fullName + ".");
            System.Console.WriteLine("Your total height in CM is " + totalHeightCM);
            System.Console.WriteLine(fullName + " can vote " + canVote);
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();


        }
    }
}
