namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public class ProductBDecision : DecisionBase
    {

        public ProductBDecision()
            : base(new BatchProductBFactory(), 3)
        {
        }
    }
}