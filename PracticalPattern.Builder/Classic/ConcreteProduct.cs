using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaolouT.Learning.PracticalPattern.Builder.Classic
{
    public class ConcreteProduct:IProduct
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
