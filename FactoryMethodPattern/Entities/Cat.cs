namespace FactoryMethodPattern.Entities
{
    public class Cat : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Cat";

        }
    }
}
