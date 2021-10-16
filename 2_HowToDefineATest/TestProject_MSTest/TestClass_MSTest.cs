using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject_MSTest
{
    [TestClass]
    public class TestClass_MSTest
    {
        [TestMethod]
        public void TestMethod()
        {
        }

        [DataTestMethod()]
        [DataRow("test1")]
        [DataRow("test2")]
        public void TheorieTestMethod(string parameter)
        {

        }
    }
}