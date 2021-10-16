using Xunit;
using FluentAssertions;

namespace UseFluentAssertations
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            int actual = 2;

            actual.Should().Be(expected);
        }
    }
}