namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start getting tickets!");
            var random = new Random();
            for (int i = 1; i <= 5; i++)
            {
                var ticket = new Ticket("Ticket" + i, 50 * i);
                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);

                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);
            }
        }

        private static void LogTicketDetails(Ticket ticket)
        {
            Console.WriteLine(
                                "Promoted price of "
                                    + ticket.Name
                                    + " is "
                                    + ticket.GetPromotedPrice()
                                    + " "
                                    + ticket.GetPromoteStrategy().GetType().Name
                            );
        }

        private static void GeneratePromoteStrategy(Random random, Ticket ticket)
        {
            var index = random.Next(0, 3);
            switch (index)
            {
                case 0:
                    ticket.SetPromotedStrategy(new NoDiscountStrategy());
                    break;
                case 1:
                    ticket.SetPromotedStrategy(new QuaterDiscountStrategy());
                    break;
                default:
                    ticket.SetPromotedStrategy(new HalfDiscountStrategy());
                    break;
            }
        }
    }
}
