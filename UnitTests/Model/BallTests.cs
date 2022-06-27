using NUnit.Framework;
using Model;
namespace UnitTests.Model
{
    [TestFixture]
    class BallTests
    {
        [Test]
        [TestCase(-1, TestName = "Side1 = -1")]
        [TestCase(0, TestName = "Side1 = 0")]
        [TestCase(1, TestName = "Side1 = 1")]
        [TestCase(1000, TestName = "Side1 = 1000")]
        [TestCase(10001, TestName = "Side1 = 10001")]
        public void BTest1(int r)
        {
            var test = new Ball(r);
        }
    }
}
