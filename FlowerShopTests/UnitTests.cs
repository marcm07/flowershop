using NUnit.Framework;
using FlowerShop;
using NSubstitute;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //ARRANGE
            IOrder order = new Order();
            IOrderDAO a = Substitute.For<IOrderDAO>(); 
            //ACT
            
            //ASSERT
            a.Received().SetDelivered();
        }
    }
}