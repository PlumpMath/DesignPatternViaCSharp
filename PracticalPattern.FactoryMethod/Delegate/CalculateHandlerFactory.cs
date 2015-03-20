namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Delegate
{
    public class CalculateHandlerFactory : IFactory<CalculateHandler>
    {
        public CalculateHandler Create()
        {
            return new Calculator().Add;
        }
    }
}
