using System.Linq;

namespace XiaolouT.Learning.PracticalPattern.Concept.Attributes
{
    public class Director
    {
        public void BuildUp(IAttributedBuilder builder)
        {
            var attributes = builder.GetType().GetCustomAttributes(typeof(DirecotrAttribute), false);
            if (attributes.Length <= 0)
            {
                return;
            }

            var directors = attributes.Select(a => a as DirecotrAttribute).OrderBy(x => x.Priority);
            foreach (var direcotrAttribute in directors)
            {
                InvokBuildPartMethod(builder, direcotrAttribute);
            }

        }

        private void InvokBuildPartMethod(IAttributedBuilder builder, DirecotrAttribute attribute)
        {
            switch (attribute.Method)
            {
                case "BuildPartA": builder.BuildPartA(); break;
                case "BuildPartB": builder.BuildPartB(); break;
                case "BuildPartC": builder.BuildPartC(); break;
            }
        }
    }
}
