using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaolouT.Learning.PracticalPattern.Builder.Classic
{
    public interface IProductBuilder
    {
        void BuildPart();
        IProduct BuildUp ();
    }
}
