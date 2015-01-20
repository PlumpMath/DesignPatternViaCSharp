
namespace XiaolouT.Learning.PracticalPattern.Builder.Classic
{
    public class CarBuilder : IBuilder
    {
        private Car car;
        public void BuildPart1()
        {
            car.AddEngine();
        }

        public void BuildPart2()
        {
            car.AddWheel();
        }

        public void BuildPart3()
        {
            car.AddBody();
        }

        public Car GetResult()
        {
            return car;
        }
    }
}
