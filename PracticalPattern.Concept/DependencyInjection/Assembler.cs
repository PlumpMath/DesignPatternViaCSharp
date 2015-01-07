using System;
using System.Collections.Generic;

namespace XiaolouT.Learning.PracticalPattern.Concept.DependencyInjection
{
    public class Assembler
    {
        private static readonly Dictionary<Type, Type> dictionary = new Dictionary<Type, Type>();

        static Assembler()
        {
            dictionary.Add(typeof(ITimeProvider), typeof(TimeProvider));
        }

        public object Create(Type type)
        {
            if (type == null || !dictionary.ContainsKey(type))
            {
                throw new NullReferenceException();
            }
            var targetType = dictionary[type];
            return Activator.CreateInstance(targetType);
        }

        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }
    }
}
