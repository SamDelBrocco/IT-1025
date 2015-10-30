namespace Assignment4
{
    class Concession
    {
        const double priceSmallSoda = 3.50;
        const double priceLargeSoda = 5.99;
        const double priceHotDog = 3.99;
        const double pricePopcorn = 4.50;
        const double priceCandy = 1.99;

        public double totalConcessionPrice = 0;
        public int SmallSoda;
        public int LargeSoda;
        public int HotDog;
        public int Popcorn;
        public int Candy;

        public void GatherConcessionData()
        {
            SmallSoda = Question.AskForInt(" How many small sodas would you like?");
            LargeSoda = Question.AskForInt(" How many large sodas?");
            HotDog = Question.AskForInt(" How many Hot Dogs?");
            Popcorn = Question.AskForInt(" How many bags of popcorn?");
            Candy = Question.AskForInt(" How many pieces of Candy?");
        }
        

        public double GetConcessionPrice()
        {
            totalConcessionPrice += SmallSoda * priceSmallSoda;
            totalConcessionPrice += LargeSoda * priceLargeSoda;
            totalConcessionPrice += HotDog * priceHotDog;
            totalConcessionPrice += Popcorn * pricePopcorn;
            totalConcessionPrice += Candy * priceCandy;

            return totalConcessionPrice;
        }
        
        public static void GatherTotalPrice()
        {
            totalConcessionPrice + 
        }


    }
}
