using System;

namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public class BatchProductFactoryBase<T> : IBatchFactory where T : IProduct, new()
    {
        public ProductCollection Create(int quatity)
        {
            if (quatity <= 0)
            {
                throw new ArgumentException();
            }
            var collection = new ProductCollection();
            for (int i = 0; i < quatity; i++)
            {
                collection.Insert(new T());
            }
            return collection;
        }
    }
}
