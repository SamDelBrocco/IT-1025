namespace Assignment4
{
    class Prices
    {
        double TicketPrice;
        public int EveningTicketCount;


        public void GatherMatineePrice()
        {
            int Child = Question.AskForInt(" How many childrens tickets do you need?");
            double ConversionChild = Child * 3.99;
            int Adult = Question.AskForInt(" How many Adult tickets do you need?");
            double ConversionAdult = Adult * 5.99;
            int Senior = Question.AskForInt(" How many Senior tickets do you need?");
            double ConversionofSenior = Senior * 4.50;

            TicketPrice = ConversionChild + ConversionAdult + ConversionofSenior;
        }

        public void GatherEveningPrice()
        {

            int Children = Question.AskForInt(" How many children tickets do you need?");
            double ConversionChild = Children * 6.99;
            int Adult = Question.AskForInt(" How many Adult tickets do you need?");
            double ConversionAdult = Adult * 10.99;
            int Senior = Question.AskForInt(" How many Senior tickets do you need?");
            double ConversionofSenior = Senior * 8.50;

            EveningTicketCount = Children + Adult + Senior;
            TicketPrice = ConversionChild + ConversionAdult + ConversionofSenior;
        }

        
    }
}
