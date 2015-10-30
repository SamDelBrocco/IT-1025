namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMovieMenu();
            CollectMovieTime();

            string command1 = System.Console.ReadLine();

            if(command1 == "1")
            {
                Prices myPrices = new Prices();
                myPrices.GatherMatineePrice();
            }
            else if (command1 == "2")
            {
                Prices myPrices = new Prices();
                myPrices.GatherEveningPrice();
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine(" Invalid Command. ");
            }
            

            ConcessionStandPrompt();
            CollectConcessionResponse();

            string command2 = System.Console.ReadLine();

            if(command2.ToLower().Contains("yes"))
            {
                Concession myConcession = new Concession();
                myConcession.GatherConcessionData();
                myConcession.GatherTotalPrice();
                System.Console.WriteLine(" Total Purchase: $" + myConcession.TotalPrice());
            }
            else if (command2.ToLower().Contains("no"))
            {
                System.Console.WriteLine(" Thats a mistake! ");
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine(" Invalid Command. ");
            }
            
            EndofProgram();
        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        private static void ShowMovieMenu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" +--------------------------------------------------------+ ");
            System.Console.WriteLine(" | Please choose what time you plan to attend the movies: | ");
            System.Console.WriteLine(" +--------------------------------------------------------+ ");
            System.Console.WriteLine(" |           (1) - Matinee: Any movie before 5pm.         | ");
            System.Console.WriteLine(" |           (2) - Evening: Any movie after 5pm.          | ");
            System.Console.WriteLine(" +--------------------------------------------------------+ ");
        }

        private static void CollectMovieTime()
        {
            System.Console.WriteLine();
            System.Console.Write(" ----> ");
        }

        private static void ConcessionStandPrompt()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" +--------------------------------------------------------+ ");
            System.Console.WriteLine(" |        Considering some snacks for your movie?         | ");
            System.Console.WriteLine(" +--------------------------------------------------------+ ");
        }

        private static void CollectConcessionResponse()
        {
            System.Console.WriteLine();
            System.Console.Write(" ----> ");
        }

        private static void EndofProgram()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" +--------------------------------------------------------+ ");
            System.Console.WriteLine(" |              Press any key to continue...              | ");
            System.Console.WriteLine(" +--------------------------------------------------------+ ");
            System.Console.Write(" ");
            System.Console.ReadKey();
        }
    }
}
