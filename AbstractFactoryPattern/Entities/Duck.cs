namespace AbstractFactoryPattern.Entities
{
    public class Duck : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Duck";
        }
    }
}
