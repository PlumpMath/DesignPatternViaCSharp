using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Delegate
{
    public  class Calculator
    {
        public int Add(params int[] items)
        {
            return items.Sum();
        }
    }
}
