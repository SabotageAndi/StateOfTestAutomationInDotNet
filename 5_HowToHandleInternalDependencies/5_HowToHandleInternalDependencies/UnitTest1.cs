using Logic;
using Xunit;

namespace _5_HowToHandleInternalDependencies
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyLogic myLogic = new MyLogic(new DependencyWithSideeffect());

            var result = myLogic.DoSomeImportantStuff();

            Assert.True(result);
        }
    }
}