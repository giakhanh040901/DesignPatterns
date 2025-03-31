using FactoryMethodPattern.Entities;

namespace FactoryMethodPattern.FactoryMethods
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }
}
