using FactoryMethodPattern.AbstractFactory;
using FactoryMethodPattern.FactoryMethods;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory;
            Random rand = new Random();
            int type = rand.Next(0, 2);
            if (type == 0)
            {
                factory = new TwoLegsAnimalFactory();
            }
            else
            {
                factory = new FourLegsAnimalFactory();
            }

            Console.WriteLine(factory.CreateAnimal().GetName());
            Console.WriteLine(factory.CreateAnimal().GetName());
            Console.WriteLine(factory.CreateAnimal().GetName());
        }
    }
}
