namespace StrategyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            var random = new Random();
            for (int i = 1; i <= 5; i++)
            {
                var ticket = new Ticket("Ticket " + i, 50 * i);
                GeneratePromoteStrategy(random, ticket);
                LogPromoteStrategy(ticket);

                GeneratePromoteStrategy(random, ticket);
                LogPromoteStrategy(ticket);
            }
        }

        private static void GeneratePromoteStrategy(Random random, Ticket ticket)
        {
            var index = random.Next(0, 4);
            switch (index)
            {
                case 0:
                    ticket.SetPromoteStrategy(new NoDiscountStrategy());
                    break;
                case 1:
                    ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
                    break;
                case 2:
                    ticket.SetPromoteStrategy(new HalfDiscountStrategy());
                    break;
                default:
                    ticket.SetPromoteStrategy(new EightyDiscountStrategy());
                    break;
            }
        }

        private static void LogPromoteStrategy(Ticket ticket)
        {
            Console.WriteLine(
                ticket.Name
                    + " is "
                    + ticket.GetPromoteDiscount()
                    + " "
                    + ticket.GetPromoteStrategy().GetType().Name
            );
        }
    }
}
