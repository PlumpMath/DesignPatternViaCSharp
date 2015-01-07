using System;
using System.Linq;

namespace XiaolouT.Learning.PracticalPattern.Concept.DependencyInjection
{
    public static class AttributeHelper
    {
        public static T Injector<T>(object target)
            where T : class
        {
            if (target == null)
            {
                throw new ArgumentNullException("target");
            }
            var targetType = target.GetType();
            var attributes = targetType.GetCustomAttributes(typeof(DecoratorAttribute), false);
            return (attributes.Length <= 0) ? null : (from attribute in (DecoratorAttribute[])attributes where attribute.Type == typeof(T) select (T)attribute.Injector).FirstOrDefault();
        }
    }
}
