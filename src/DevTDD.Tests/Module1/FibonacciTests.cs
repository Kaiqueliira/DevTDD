using DevTDD.Core.Services;
using FluentAssertions;

namespace DevTDD.Tests.Module1
{
    public class FibonacciTests
    {
        [Fact]
        public void Fibonacci_PositionZero_ShouldReturnZero()
        {
            int position = 0;

            int result = FibonacciServices.GetFibonacci(position);

            result.Should().Be(0);
        }
    }
}


