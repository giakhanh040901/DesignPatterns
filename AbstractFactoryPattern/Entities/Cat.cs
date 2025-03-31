namespace AbstractFactoryPattern.Entities
{
    public class Cat : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Cat";
        }
    }
}
