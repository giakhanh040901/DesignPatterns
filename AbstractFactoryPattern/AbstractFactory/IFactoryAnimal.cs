using AbstractFactoryPattern.Entities;

namespace AbstractFactoryPattern.AbstractFactory
{
    public interface IFactoryAnimal
    {
        IAnimal CreateAnimal();
    }
}
