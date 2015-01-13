namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Delegate
{
    public interface IFactory<out T>
    {
        T Create();
    }
}
