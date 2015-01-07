using System.Collections.Generic;
using System.Threading;


namespace XiaolouT.Learning.PracticalPattern.Concept.Delegating
{
    public class AsyncInvoker
    {
        private readonly List<string> _output = new List<string>();

        public AsyncInvoker()
        {
            var slowTimer = new Timer(OnTimerInterval, "slow", 2500, 2500);
            var fastTimer = new Timer(OnTimerInterval, "fast", 2000, 2500);
            _output.Add("method");

        }

        private void OnTimerInterval(object state)
        {
            _output.Add(state as string);
        }

        public List<string> Output
        {
            get
            {
                return _output;
            }
        }
    }
}
