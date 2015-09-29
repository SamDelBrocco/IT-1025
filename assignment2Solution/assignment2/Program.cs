namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person P1 = new Person();
            P1.GetFullName();
            P1.PrintNameAndAge();
            P1.MaritalStatus();


            Person P2 = new Person();;
            P2.GetFullName();
            P2.PrintNameAndAge();
            P2.MaritalStatus();


            Person P3 = new Person();
            P3.GetFullName();
            P3.PrintNameAndAge();
            P3.MaritalStatus();


            System.Console.WriteLine("Average age of all people is " + P3.AverageAge());
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();

        }
    }
}
