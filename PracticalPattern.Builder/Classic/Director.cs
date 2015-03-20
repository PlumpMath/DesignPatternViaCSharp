
namespace XiaolouT.Learning.PracticalPattern.Builder.Classic
{
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();

        }
    }
}
