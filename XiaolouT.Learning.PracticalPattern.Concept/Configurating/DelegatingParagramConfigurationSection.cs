using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating
{
    public class DelegatingParagramConfigurationSection : ParagraphConfigurationSectionBase
    {
        private const string PicturesItem = "pictures";

        [ConfigurationProperty(PicturesItem, IsRequired = false)]
        public virtual PictureConfigurationElementCollection Pictures
        {
            get
            {
                return base[PicturesItem] as PictureConfigurationElementCollection;
            }
        }
    }
}