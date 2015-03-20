using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaolouT.Learning.PracticalPattern.Builder.Classic
{
    public class ConcreteBuilderA:IProductBuilder
    {
        private readonly IProduct product = new ConcreteProduct();
        public void BuildPart()
        {
            product.Name = "A";
        }

        public IProduct BuildUp()
        {
            return product;
        }
    }
}
