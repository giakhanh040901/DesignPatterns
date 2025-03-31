namespace FactoryMethodPattern.Entities
{
    public class Chicken : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Chicken";
        }
    }
}
