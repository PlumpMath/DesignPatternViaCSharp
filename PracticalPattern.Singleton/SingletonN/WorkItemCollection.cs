using System;
using System.Collections.Generic;

namespace XiaolouT.Learning.PracticalPattern.Singleton.SingletonN
{
    public class WorkItemCollection<T>
        where T : class ,IWorkItem
    {
        protected int max;

        protected IList<T> items = new List<T>();

        public WorkItemCollection(int _max)
        {
            max = _max;
        }

        public virtual T GetWorkItem()
        {
            if (items == null || items.Count == 0)
            {
                return null;
            }
            foreach (var item in items)
            {
                if (item.Status == Status.Free)
                {
                    item.Status = Status.Busy;
                    return item;
                }
            }
            return null;
        }

        public virtual void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            if (!CouldAddNewInstance)
            {
                throw new OverflowException();
            }
            item.Status = Status.Free;
            items.Add(item);
        }


        public virtual bool CouldAddNewInstance
        {
            get { return (items.Count < max); }
        }

    }
}
