using NUnit.Framework;
using Model;
namespace UnitTests.Model
{
    [TestFixture]
    class PyramidTests
    {
        [Test]
        [TestCase(-1, TestName = "Side2 = -1")]
        [TestCase(0, TestName = "Side2 = 0")]
        [TestCase(1, TestName = "Side2 = 1")]
        [TestCase(1000, TestName = "Side2 = 1000")]
        [TestCase(10001, TestName = "Side2 = 10001")]
        public void PTestS2(int h)
        {
            var test = new Pyramid(1, h);
        }
    }
}
