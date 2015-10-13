namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "Doe", "English");
            
            Instructor Mike = new Instructor("Mike", "Smith", "Math");
            


            Student Jane = new Student("Jane", 0, John);

            Student Joe = new Student("Joe", 0, John);

            Student Melissa = new Student("Melissa", 0, Mike);

            Student Matt = new Student("Matt", 0, Mike);

            








        }
    }
}
