using Xunit;
using Moq;
using Logic;

namespace UseMoq
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dependencyWithSideeffectMock = new Mock<IDependencyWithSideeffect>();

            MyLogic myLogic = new MyLogic(dependencyWithSideeffectMock.Object);

            var result = myLogic.DoSomeImportantStuff();

            Assert.True(result);
        }
    }
}