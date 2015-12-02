namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = true;
            while (input)
            { 
            Course course = new Course();
            course.Name = Question.AskForString(" Course Name? ");
            course.CRN = Question.AskForInt(" Course CRN number? ");
            int size = Question.AskForInt(" Number of Students? ");

            Widget[] students = new Widget[size];

            for (int i = 0; i < size; i++)
            {
                students[i] = new Widget();
                students[i].SetID(Question.AskForString(" Student Name? "));
                students[i].SetDescription(Question.AskForString(" Student Snumber? "));
            }
            
            foreach (Widget Student in students)
            {
                Student.Print();
            }

            input = Question.AskForString(" Would you like to start over? ").ToLower().StartsWith("y");

            }

            System.Console.WriteLine();
            System.Console.WriteLine(" Press any key to continue...");
            System.Console.Write(" ");
            System.Console.ReadKey();
        }
    }
}
