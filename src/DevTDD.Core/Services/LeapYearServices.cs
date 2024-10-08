
namespace DevTDD.Core.Services;

public class LeapYearServices
{
    public static bool IsLeapYear(int year) => ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
}
