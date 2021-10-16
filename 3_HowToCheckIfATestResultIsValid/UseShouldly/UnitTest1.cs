using Shouldly;
using Xunit;

namespace UseShouldly
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            int actual = 2;

            actual.ShouldBe(expected);
        }
    }
}