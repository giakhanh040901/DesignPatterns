using AbstractFactoryPattern.Entities;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class FourLegsAnimalFactory : AbstractFactoryAnimal
    {
        public override IAnimal CreateAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Dog();
            }
            else
            {
                return new Cat();
            }
        }
    }
}
