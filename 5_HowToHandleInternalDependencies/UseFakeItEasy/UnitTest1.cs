using FakeItEasy;
using Logic;
using Xunit;

namespace UseFakeItEasy
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dependencyWithSideeffectMock = A.Fake<IDependencyWithSideeffect>();

            MyLogic myLogic = new MyLogic(dependencyWithSideeffectMock);

            var result = myLogic.DoSomeImportantStuff();

            Assert.True(result);
        }
    }
}