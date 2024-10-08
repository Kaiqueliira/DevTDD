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

    [Fact]
    public void IsLeapYear_ShouldReturnFalse_WhenDivisibleBy100()
    {
        int year = 1900;

        var result = LeapYearServices.IsLeapYear(year);

        result.Should().BeFalse();
    }

    [Fact]
    public void IsLeapYear_ShouldReturnTrue_WhenDivisibleBy400()
    {
        int year = 2000;

        var result = LeapYearServices.IsLeapYear(year);

        result.Should().BeTrue();
    }

    [Fact]
    public void IsLeapYear_ShouldReturnFalse_WhenNotDivisibleBy4()
    {
        int year = 2017;

        var result = LeapYearServices.IsLeapYear(year);

        result.Should().BeFalse();
    }
}