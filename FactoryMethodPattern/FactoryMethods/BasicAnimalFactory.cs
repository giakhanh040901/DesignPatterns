using FactoryMethodPattern.Entities;

namespace FactoryMethodPattern.FactoryMethods
{
    public class BasicAnimalFactory : IAnimalFactory
    {
        int index = 0;
        public IAnimal CreateAnimal()
        {
            if (index == 0)
            {
                index++;
                return new Dog();
            }
            else if (index == 1)
            {
                index++;
                return new Cat();
            }
            else if (index == 2)
            {
                index = 0;
                return new Duck();
            }

            return null;
        }
    }
}
