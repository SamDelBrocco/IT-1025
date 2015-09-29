namespace assignment2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public static int TotalPersonAge = 0;
        public static int PersonCount = 0;
        public static int SpouseCount = 0;


        public string GetFullName()
        {
            PersonCount++;
            System.Console.WriteLine("Enter person " + PersonCount + " FirstName: ");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Enter person " + PersonCount + " LastName: ");
            LastName = System.Console.ReadLine();

            return this.FirstName + " " + this.LastName + " ";
        }


        public void PrintNameAndAge()
        {
            System.Console.WriteLine("Enter person " + PersonCount + " age: ");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(this.FirstName + " " + this.LastName + " " + Age);
            TotalPersonAge += Age;
        }


        public bool MaritalStatus()
        {
            System.Console.WriteLine("Is person married?");
            bool Married;
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                Married = true;
                NewSpouse();
            }
            else
            {
                Married = false;
                System.Console.WriteLine("No spouse ");
            }
            return Married;
        }


        public void NewSpouse()
        {
            Spouse = new Person();
            SpouseCount++;
            System.Console.WriteLine("What is their spouse first name? ");
            Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is their age? ");
            Spouse.Age = int.Parse(System.Console.ReadLine());
            TotalPersonAge += Spouse.Age;
        }


        public void SpouseNameAndAge()
        {
            System.Console.WriteLine(Spouse.FirstName + " " + LastName + " " + Spouse.Age);
        }


        public double AverageAge()
        {
            System.Console.WriteLine("The average age is: ");
            return TotalPersonAge / (PersonCount + SpouseCount);
        }


    }

}
