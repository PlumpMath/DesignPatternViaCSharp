using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaolouT.Learning.PracticalPattern.Builder.Classic
{
    public class ProductBuilderDirector
    {
        public void Construct(IProductBuilder builder)
        {
            builder.BuildPart();
        }
    }
}
