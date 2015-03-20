
namespace XiaolouT.Learning.PracticalPattern.Builder.Classic
{
    public class HouseBuilder : IBuilder
    {
        private House house;
        public void BuildPart1()
        {
            house.AddWallAndFloor();
        }

        public void BuildPart2()
        {
            house.AddWindowAndDoor();
        }

        public void BuildPart3()
        {
            house.AddCeiling();
        }

        public House GetResult()
        {
            return house;
        }
    }
}
