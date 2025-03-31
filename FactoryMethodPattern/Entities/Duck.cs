namespace FactoryMethodPattern.Entities
{
    public class Duck : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Duck";
        }
    }
}
