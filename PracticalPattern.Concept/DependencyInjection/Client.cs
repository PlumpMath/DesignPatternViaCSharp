
namespace XiaolouT.Learning.PracticalPattern.Concept.DependencyInjection
{
    [Decorator(typeof(ITimeProvider))]
    public class Client
    {
        public int GetYear()
        {
            var provider = AttributeHelper.Injector<ITimeProvider>(this);
            return provider.CurrentDate.Year;
        }
    }
}
