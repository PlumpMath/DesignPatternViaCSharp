using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating
{
    [ConfigurationCollection(typeof(NamedConfigurationElementBase), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public abstract class NamedConfigurationElementCollectionBase<T> : ConfigurationElementCollection
        where T : NamedConfigurationElementBase, new()
    {
        public T this[int index]
        {
            get
            {
                return (T) BaseGet(index);
            }
        }

        public new T this[string name]
        {
            get
            {
                return (T) BaseGet(name);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return  new T();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as T).Name;
        }
    }
}
