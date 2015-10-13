namespace Lab3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student (string theirName, int theirGrade, Instructor theirTeacher)
        {
            this.Name = theirName;
            this.Grade = theirGrade;
            this.Instructor = thierTeacher;
        }

    }
}
