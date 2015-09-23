namespace assignment2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public string SpouseName;
        public int SpouseAge;
        public bool IsMarried()
        {
            return Spouse != null;
        }   


    public void GatherDataFromUser()
        {
            System.Console.Write("What is your first name: ");
            FirstName = System.Console.ReadLine();
            System.Console.Write("What is your last name: ");
            LastName = System.Console.ReadLine();
            System.Console.Write("What is your age: ");
            Age = int.Parse(System.Console.ReadLine());
        }


        public string GetFullName ()
        {
            string FullName = "";
            FullName += this.FirstName;
            FullName += " ";
            FullName += this.LastName;
            return FullName;
        }


        public string GetSpouseFullName ()
        {
            string SpouseFullName = " ";
            SpouseFullName += this.SpouseName;
            SpouseFullName += " ";
            SpouseFullName += this.LastName;
            return SpouseFullName;
        }


        public void PrintNameAndAge()
        {
            System.Console.WriteLine("My name is " + this.GetFullName());
            System.Console.WriteLine("My age is " + this.Age);
        }


        public void PrintSpouseNameAndAge()
        {
            System.Console.WriteLine("My Spouses name is " + this.GetSpouseFullName());
            System.Console.WriteLine("My Spouses age is " + this.SpouseAge);
        }


    }
}
