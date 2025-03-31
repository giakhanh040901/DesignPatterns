using FactoryMethodPattern.Entities;
using FactoryMethodPattern.FactoryMethods;

namespace FactoryMethodPattern.AbstractFactory
{
    public abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
