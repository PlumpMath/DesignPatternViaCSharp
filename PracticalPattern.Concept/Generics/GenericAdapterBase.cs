
namespace XiaolouT.Learning.PracticalPattern.Concept.Generics
{
    public interface ITarget
    {
        void Request();
    }

    public interface IAdaptee
    {
        void SpecifiedRequest();
    }
    public abstract class GenericAdapterBase<T> : ITarget
        where T : IAdaptee, new()
    {
        public void Request()
        {
            new T().SpecifiedRequest();
        }
    }
}
