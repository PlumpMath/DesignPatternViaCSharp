using System.Linq;

namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public class Client
    {
        private readonly DirectorBase director = new ProductDirector();

        public IProduct[] Produce()
        {
            var collection = new ProductCollection();
            collection = director.Decisions.Aggregate(collection, (current, decision) => current + decision.Factory.Create(decision.Quantity));
            return collection.Data;
        }
    }
}