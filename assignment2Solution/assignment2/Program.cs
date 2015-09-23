namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person P1 = new Person();
            P1.GatherDataFromUser();
            System.Console.WriteLine("Married? (y/n) ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                P1.Spouse = new Person();
                P1.Spouse.SpouseName = " ";
            }


            Person P2 = new Person();;
            P2.GatherDataFromUser();
            System.Console.WriteLine("Married? (y/n) ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                P2.Spouse = new Person();
                P2.Spouse.SpouseName = " ";
            }

            Person P3 = new Person();
            P3.GatherDataFromUser();
            System.Console.WriteLine("Married? (y/n) ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                P3.Spouse = new Person();
                P3.Spouse.SpouseName = " ";
            }


            System.Console.WriteLine(P1.PrintNameAndAge());
            System.Console.WriteLine(P1.PrintSpouseNameAndAge());
            System.Console.WriteLine(P2.PrintNameAndAge());
            System.Console.WriteLine(P2.PrintSpouseNameAndAge());
            System.Console.WriteLine(P3.PrintNameAndAge());
            System.Console.WriteLine(P3.PrintSpouseNameAndAge());

        }
    }
}
