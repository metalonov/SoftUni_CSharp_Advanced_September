﻿namespace DateModifier
{
    public static class DateModifier
    {
        public static int GetDifferenceInDays(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            TimeSpan difference = endDate - startDate;
            int differenceInDays = difference.Days;

            return Math.Abs(differenceInDays);
        }
    }
}
