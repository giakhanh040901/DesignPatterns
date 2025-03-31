using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    public class Ticket
    {
        public double Price { get; set; }   
        public string Name { get; set; }
        private IPromoteStrategy _promoteStrategy;

        public Ticket(string name, double price) 
        {
            this.Name = name;
            this.Price = price;
        }

        public Ticket(IPromoteStrategy promoteStrategy) 
        {
            _promoteStrategy = promoteStrategy;
        }

        public IPromoteStrategy GetPromoteStrategy() 
        {
            return _promoteStrategy;
        }

        public void SetPromoteStrategy(IPromoteStrategy promoteStrategy)
        {
            _promoteStrategy = promoteStrategy;
        }

        public double GetPromoteDiscount()
        {
            return _promoteStrategy.DoDiscount(this.Price);
        }
    }
}
