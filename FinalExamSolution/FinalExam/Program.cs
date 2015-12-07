namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevator1IsOverMaxCapacity;
            bool elevator2IsOverMaxCapacity;

            Elevator elevator1 = new Elevator(2, 400);
            Passenger A1 = new Passenger("A1", 180);
            elevator1.AddOccupant(A1, 0);
            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(A2, 1);

            Elevator elevator2 = new Elevator(3, 600);
            A1 = new Passenger("A1", 200);
            elevator2.AddOccupant(A1, 0);
            A2 = new Passenger("A2", 200);
            elevator2.AddOccupant(A2, 1);
            Passenger A3 = new Passenger("A3", 201);
            elevator2.AddOccupant(A3, 2);

            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
            

        }
    }
}
