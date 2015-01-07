using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating
{
    public abstract class ParagraphConfigurationSectionBase : ConfigurationSection
    {
        private const string ExamplesItem = "examples";
        private const string DiagramsItem = "diagrams";

        [ConfigurationProperty(ExamplesItem, IsRequired = false)]
        public virtual ExampleConfigurationElementCollection Examples
        {
            get
            {
                return base[ExamplesItem] as ExampleConfigurationElementCollection;
            }
        }

        [ConfigurationProperty(DiagramsItem, IsRequired = false)]
        public virtual DiagramConfigurationElementCollection Diagrams
        {
            get
            {
                return base[DiagramsItem] as DiagramConfigurationElementCollection;
            }
        }
    }
}
