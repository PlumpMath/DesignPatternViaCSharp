using System.Collections.Generic;

namespace XiaolouT.Learning.PracticalPattern.Concept.Attributes
{
    [Direcotr(1, "BuildPartB")]
    [Direcotr(2, "BuildPartA")]
    public class AttributedBuilder : IAttributedBuilder
    {
        private readonly IList<string> _log = new List<string>();
        public IList<string> Log { get { return _log; } }
        public void BuildPartA()
        {
            _log.Add("a");
        }

        public void BuildPartB()
        {
            _log.Add("b");
        }

        public void BuildPartC()
        {
            _log.Add("c");
        }
    }
}
