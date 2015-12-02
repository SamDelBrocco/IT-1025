namespace Assignment5
{
    class Widget
    {
        private string _id;
        public string GetID() { return _id; }
        public void SetID(string id) { _id = id; }

        private string _description;
        public string GetDescription() { return _description; }
        public void SetDescription(string description) { _description = description; }

        public void Print()
        {
            System.Console.WriteLine( " " + this.GetID() + " " + this.GetDescription());
        }
    }
}
