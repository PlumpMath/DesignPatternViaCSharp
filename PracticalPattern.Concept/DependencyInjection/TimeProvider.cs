using System;

namespace XiaolouT.Learning.PracticalPattern.Concept.DependencyInjection
{
    public class TimeProvider:ITimeProvider
    {
        public DateTime CurrentDate
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
