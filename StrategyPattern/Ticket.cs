namespace StrategyPattern
{
    public class Ticket
    {
        private IPromoteStrategy _promote;
        public double Price { get; set; }
        public string? Name { get; set; }

        public Ticket(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Ticket(IPromoteStrategy promote)
        {
            _promote = promote;
        }

        public void SetPromotedStrategy(IPromoteStrategy value)
        {
            _promote = value;
        }

        public double GetPromotedPrice()
        {
            return _promote.DoDiscount(this.Price);
        }

        public IPromoteStrategy GetPromoteStrategy()
        {
            return _promote;
        }
    }
}
