namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public abstract class DecisionBase
    {
        protected IBatchFactory _factory;
        protected int _quantity;

        protected DecisionBase(IBatchFactory factory, int quantity)
        {
            _factory = factory;
            _quantity = quantity;
        }

        public virtual IBatchFactory Factory
        {
            get { return _factory; }
        }

        public virtual int Quantity
        { get { return _quantity; } }
    }
}
