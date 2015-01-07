using System;

namespace XiaolouT.Learning.PracticalPattern.Concept.Generics
{
    public static class RawGenericFactory
    {
        public static T Create<T>(string typeName)
        {
            return (T)Activator.CreateInstance(Type.GetType(typeName));
        }
    }
}
