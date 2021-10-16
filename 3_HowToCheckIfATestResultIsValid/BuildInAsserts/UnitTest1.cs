using Xunit;

namespace BuildInAsserts
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            int actual = 2;

            Assert.Equal(expected, actual);
        }
    }
}