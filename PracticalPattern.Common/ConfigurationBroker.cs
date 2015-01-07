using System;
using System.Collections.Generic;
using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Common
{
    public class ConfigurationBroker
    {
        private static readonly GenericCache<Type, object> cache;

        static ConfigurationBroker()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cache=new GenericCache<Type, object>();
            foreach (var group in config.SectionGroups)
            {
                if (typeof(IConfigurationSource).IsAssignableFrom(group.GetType()))
                {
                    ((IConfigurationSource)group).Load();
                }
            }
        }

        public static void Add(Type type, object item)
        {
            if (type==null||item==null)
            {
                throw  new NullReferenceException();
            }
            cache.Add(type,item);
        }

        public static void Add(KeyValuePair<Type, object> item)
        {
            Add(item.Key,item.Value);
        }

        public static void Add(object item)
        {
            Add(item.GetType(),item);
        }

        public static T GetConfigurationObject<T>()
            where T:class 
        {
            if (cache.Count<=0)
            {
                return null;
            }
            object result;
            if (!cache.TryGetValue(typeof(T), out result))
            {
                return null;
            }
            return (T) result;
        }
    }
}
