using DotNet.BrazilRandomMessage.Message;
using DotNet.BrazilRandomMessage.Message.Base;
using DotNet.BrazilRandomMessage.Message.Extention;
using System;
using System.Collections.Generic;
using System.Text;
using DayOfWeek = System.DayOfWeek;

namespace DotNet.BrazilRandomMessage
{
    public static class Messages
    {
        public static DateTime ToDateTime { get; set; } = DateTime.Today;

        public static bool ToDateTimeIsSunday => ToDateTime.DayOfWeek == DayOfWeek.Sunday;

        public static bool ToDateTimeIsFriday => ToDateTime.DayOfWeek == DayOfWeek.Friday;

        public static bool ToDateTimeIsWeekend => ToDateTime.DayOfWeek == DayOfWeek.Friday || ToDateTime.DayOfWeek == DayOfWeek.Saturday;

        public static bool ToDateTimeIsHoliday => new Holiday(ToDateTime).FromDateIsHoliday;

        private static bool IsNotIncludeHoliday { get; set; }

        private static bool IsNotIncludeFriday { get; set; }

        private static bool IsNotIncludeSunday { get; set; }

        private static bool IsNotIncludeWeekend { get; set; }

        public static string GetOne()
        {
            if (ToDateTimeIsHoliday && !IsNotIncludeHoliday)
                return new Holiday(ToDateTime).PickARandomMessage();

            if (ToDateTimeIsFriday && !IsNotIncludeFriday)
                return new Friday().PickARandomMessage();

            if (ToDateTimeIsSunday && !IsNotIncludeSunday)
                return new Sunday().PickARandomMessage();

            if (ToDateTimeIsWeekend && !IsNotIncludeWeekend)
                return new Weekend().PickARandomMessage();

            return new Welcome().PickARandomMessage();
        }

        public static void ToDate(DateTime dateToGetMessage)
        {
            ToDateTime = dateToGetMessage;
        }

        public static void NotIncludeHoliday()
        {
            IsNotIncludeHoliday = true;
        }

        public static void NotIncludeFriday()
        {
            IsNotIncludeFriday = true;
        }

        public static void NotIncludeSunday()
        {
            IsNotIncludeSunday = true;
        }

        public static void NotIncludeWeekend()
        {
            IsNotIncludeWeekend = true;
        }
    }
}
