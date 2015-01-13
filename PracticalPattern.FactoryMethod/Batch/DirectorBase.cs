using System;
using System.Collections.Generic;

namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch
{
    public abstract class DirectorBase
    {
        protected IList<DecisionBase> decisions = new List<DecisionBase>();

        protected virtual void Insert(DecisionBase decision)
        {
            if (decision != null && decision.Factory != null && decision.Quantity > 0)
            {
                decisions.Add(decision);
            }
            else
            {
                throw new ArgumentException("decision");
            }
        }

        public virtual IEnumerable<DecisionBase> Decisions
        {
            get { return decisions; }
        }

    }
}