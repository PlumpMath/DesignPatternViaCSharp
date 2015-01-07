using System;

namespace XiaolouT.Learning.PracticalPattern.Concept.DependencyInjection
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class DecoratorAttribute:Attribute
    {
        public readonly object Injector;

        private readonly Type type;

        public DecoratorAttribute(Type type)
        {
            if (type==null)
            {
                throw new ArgumentNullException("type");
            }
            this.type = type;
            Injector = new Assembler().Create(this.type);
        }

        public Type Type
        {
            get
            {
                return type;
            }
        }
    }
}
