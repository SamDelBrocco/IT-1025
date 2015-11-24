namespace Assignment5
{
    class Student
    {
        public void GatherStudentInfo()
        {
            int count = Question.AskForInt(" How many students are in this course? ");
            Widget[] students = new Widget[count];
            
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Widget();
                students[i].SetDescription(Question.AskForString(" Student Name "));
                students[i].SetID(Question.AskForInt(" S-Number "));
            }

            foreach (Widget student in students)
            {
                student.Print();
            }
        }





    }
}
