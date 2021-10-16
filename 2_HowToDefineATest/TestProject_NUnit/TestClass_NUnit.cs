using NUnit.Framework;

namespace TestProject_NUnit
{
    public class TestClass_NUnit
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            Assert.Pass();
        }

        [TestCase("test1")]
        [TestCase("test2")]
        public void TestCase(string parameter)
        {

        }
    }
}