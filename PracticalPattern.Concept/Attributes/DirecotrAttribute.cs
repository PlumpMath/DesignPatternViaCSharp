using System;

namespace XiaolouT.Learning.PracticalPattern.Concept.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class DirecotrAttribute : Attribute, IComparable<DirecotrAttribute>
    {
        public int Priority { get; private set; }
        public string Method { get; private set; }

        public DirecotrAttribute(int priority, string method)
        {
            Priority = priority;
            Method = method;
        }

        public int CompareTo(DirecotrAttribute other)
        {
            return other.Priority - Priority;
        }
    }
}
