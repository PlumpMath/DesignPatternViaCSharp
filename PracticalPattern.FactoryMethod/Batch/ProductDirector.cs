namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public sealed class ProductDirector : DirectorBase
    {
        public ProductDirector()
        {
            Insert(new ProductADecision());
            Insert(new ProductBDecision());
        }
    }
}