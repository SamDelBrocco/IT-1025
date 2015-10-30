namespace Assignment4
{
    class Question
    {
        public static string AskForString (string prompt)
        {
            System.Console.Write(prompt.PadRight(40) + " : ");
            return System.Console.ReadLine();
        }

        public static int AskForInt(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }
    }
}
