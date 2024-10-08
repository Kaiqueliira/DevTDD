using DevTDD.Core.Services;
using FluentAssertions;

namespace DevTDD.Tests.Module1;

public class LeapYearTests
{
    [Fact]
    public void IsLeapYear_ShouldReturnTrue_WhenDivisibleBy4()
    {
        int year = 2016;

        var result = LeapYearServices.IsLeapYear(year);

        result.Should().BeTrue();
    }
}