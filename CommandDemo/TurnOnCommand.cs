using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    public class TurnOnCommand : ICommand
    {
        private readonly Fan _fan;

        public TurnOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOn();
        }

        public void Undo()
        {
            _fan.TurnOff();
        }
    }
}
