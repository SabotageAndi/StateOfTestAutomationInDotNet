using Xunit;

namespace TestProject_xUnit
{
    public class TestClass_xUnit
    {
        [Fact]
        public void Fact()
        {

        }

        [Theory]
        [InlineData("test1")]
        [InlineData("test2")]
        public void Theory(string parameter)
        {
        }

    }
}