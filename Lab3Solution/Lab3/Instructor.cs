namespace Lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public string ProfInfo()
        {
            return "professor " + this.Name + " who teaches " + this.CourseName;
        }
        
        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }
        
       

    }
}
