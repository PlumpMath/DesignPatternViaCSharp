using System;

namespace XiaolouT.Learning.PracticalPattern.Common
{
    public class TypeCreator : IObjectBuilder
    {
        public T BuildUp<T>(object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }

        public T BuildUp<T>() where T : new()
        {
            return Activator.CreateInstance<T>();
        }

        public T BuildUp<T>(string typeName)
        {
            return (T)Activator.CreateInstance(Type.GetType(typeName));
        }

        public T BuildUp<T>(string typeName, object[] args)
        {
            return (T)Activator.CreateInstance(Type.GetType(typeName), args);
        }
    }
}
