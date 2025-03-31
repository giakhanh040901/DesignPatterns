using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern
{
    public static class Program
    {
        static void Main(string[] args)
        {
            IFactoryAnimal factory;
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                factory = new FourLegsAnimalFactory();
            }
            else
            {
                factory = new TwoLegsAnimalFactory();
            }

            Console.WriteLine(factory.CreateAnimal().GetName());
            Console.WriteLine(factory.CreateAnimal().GetName());
            Console.WriteLine(factory.CreateAnimal().GetName());
            Console.WriteLine(factory.CreateAnimal().GetName());
            Console.WriteLine(factory.CreateAnimal().GetName());
            Console.WriteLine(factory.CreateAnimal().GetName());
        }
    }
}
