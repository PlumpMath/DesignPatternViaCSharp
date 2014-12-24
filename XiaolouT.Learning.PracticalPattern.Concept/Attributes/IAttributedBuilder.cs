using System.Collections.Generic;

namespace XiaolouT.Learning.PracticalPattern.Concept.Attributes
{
    public interface IAttributedBuilder
    {
        IList<string> Log { get; }
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
