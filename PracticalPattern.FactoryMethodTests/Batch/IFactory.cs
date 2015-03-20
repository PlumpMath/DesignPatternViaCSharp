namespace PracticalPattern.FactoryMethodTests.Batch
{
    public interface IFactory<out T>
    {
        T Create();
    }
}
