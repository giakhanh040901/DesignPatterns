namespace FactoryMethodPattern.Entities
{
    public class Dog : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Dog";
        }
    }
}
