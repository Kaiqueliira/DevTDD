﻿
namespace DevTDD.Core.Services;

public class LeapYearServices
{
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0) return true;

        return false;
    }
}
