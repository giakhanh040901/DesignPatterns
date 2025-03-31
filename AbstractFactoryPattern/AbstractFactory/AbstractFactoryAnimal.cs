using AbstractFactoryPattern.Entities;

namespace AbstractFactoryPattern.AbstractFactory
{
    public abstract class AbstractFactoryAnimal : IFactoryAnimal
    {
        public abstract IAnimal CreateAnimal();
    }
}
