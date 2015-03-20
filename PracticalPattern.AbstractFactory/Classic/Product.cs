
namespace XiaolouT.Learning.PracticalPattern.AbstractFactory.Classic
{
    public class ProductA1 : IProductA
    {
    }

    public class ProductA2X : IProductA
    {

    }

    public class ProductA2Y : IProductA
    {

    }

    public class ProductB1 : IProductB
    {

    }

    public class ProductB2 : IProductB
    {

    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public virtual IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public virtual IProductA CreateProductA()
        {
            return new ProductA2Y();
        }

        public virtual IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
