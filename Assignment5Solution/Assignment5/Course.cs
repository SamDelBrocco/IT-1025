namespace Assignment5
{
    class Course
    {
        public static string Name;
        public static int CRN;
        public static string PrintCourse;

        public void GatherCourseInfo()
        {
            Name = Question.AskForString(" What is the course name? ");
            CRN = Question.AskForInt(" What is the course number? ");
        }
        
        public string Print()
        {
            return " Course Name and Number: " + Name + " " + CRN;
        }
    }
}
