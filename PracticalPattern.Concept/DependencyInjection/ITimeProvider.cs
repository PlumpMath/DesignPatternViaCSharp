using System;

namespace XiaolouT.Learning.PracticalPattern.Concept.DependencyInjection
{
    interface ITimeProvider
    {
        DateTime CurrentDate { get; }
    }
}
