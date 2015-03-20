
namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public class ProductADecision : DecisionBase
    {

        public ProductADecision()
            : base(new BatchProductAFactory(), 2)
        {
        }
    }
}
