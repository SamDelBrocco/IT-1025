namespace FinalExam
{
    public class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;
       

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            return Passenger.SumOfWeight;
        }

        public bool IsOverMaxCapacity()
        {

            if (GetCurrentWeight() >= MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
