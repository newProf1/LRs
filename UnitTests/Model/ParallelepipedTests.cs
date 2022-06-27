using NUnit.Framework;
using Model;
namespace UnitTests.Model
{
    [TestFixture]
    class ParallelepipedTests
    {
        [Test]
        [TestCase(-1, TestName = "Side3 = -1")]
        [TestCase(0, TestName = "Side3 = 0")]
        [TestCase(1, TestName = "Side3 = 1")]
        [TestCase(1000, TestName = "Side3 = 1000")]
        [TestCase(10001, TestName = "Side3 = 10001")]
        public void PTestS3(int s3)
        {
            var test = new Parallelepiped(1, 1, s3);
        }
    }
}
