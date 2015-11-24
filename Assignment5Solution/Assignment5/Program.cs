namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            Course course = new Course();
            course.GatherCourseInfo();
            Student ListofStudents = new Student();
            ListofStudents.GatherStudentInfo();
            

            System.Console.WriteLine();
            System.Console.WriteLine(" Press any key to continue...");
            System.Console.Write(" ");
            System.Console.ReadKey();
        }
    }
}
