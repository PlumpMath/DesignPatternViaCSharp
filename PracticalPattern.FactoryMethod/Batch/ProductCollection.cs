using System.Collections.Generic;
using System.Linq;

namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public class ProductCollection
    {
        private readonly IList<IProduct> _data = new List<IProduct>();

        public void Insert(IProduct item)
        {
            _data.Add(item);
        }

        public void Insert(IProduct[] items)
        {
            if (items != null && items.Length > 0)
            {
                foreach (var item in items)
                {
                    Insert(item);
                }
            }
        }

        public void Remove(IProduct item)
        {
            _data.Remove(item);
        }

        public IProduct[] Data
        {
            get
            {
                if (_data != null && _data.Count > 0)
                {
                    return _data.ToArray();
                }
                return null;
            }
        }

        public int Count
        {
            get { return _data.Count; }
        }

        public static ProductCollection operator +(ProductCollection collection, IProduct[] items)
        {
            var result = new ProductCollection();
            if (collection != null && collection.Count > 0)
            {
                result.Insert(collection.Data);
            }
            if (items != null && items.Length > 0)
            {
                result.Insert(items);
            }
            return result;
        }

        public static ProductCollection operator +(ProductCollection source, ProductCollection target)
        {
            var result = new ProductCollection();
            if (source != null && source.Count > 0)
            {
                result.Insert(source.Data);
            }
            if (target != null && target.Count > 0)
            {
                result.Insert(target.Data);
            }
            return result;
        }
    }
}
