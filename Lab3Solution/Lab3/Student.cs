namespace Lab3
{
    class Student
    {
        private string Name;
        private Instructor Teacher;
        private int Grade = 0;


        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }


        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public string StudentInfo()
        {
           return this.Name + " received a " + this.Grade + "% from ";
        }


        public void Print()
        {
            System.Console.WriteLine("Student " + StudentInfo() + Teacher.ProfInfo());
        }



    }
}
