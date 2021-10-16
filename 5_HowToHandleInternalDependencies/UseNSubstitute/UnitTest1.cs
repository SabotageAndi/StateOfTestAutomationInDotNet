using Logic;
using NSubstitute;
using Xunit;

namespace UseNSubstitute
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dependencyWithSideeffectMock = Substitute.For<IDependencyWithSideeffect>();

            MyLogic myLogic = new MyLogic(dependencyWithSideeffectMock);

            var result = myLogic.DoSomeImportantStuff();

            Assert.True(result);
        }
    }
}