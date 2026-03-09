using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class ChronoClass
    {
        public enum TimeFormat { TwelveHour, TwentyFourHour }
        public enum ShortTime { hhdmm, hhpmm, hhdmmds, hhpmmps }
        public enum ShortDate { mmzddzyy, ddzmmzyy, mmxddxyy, ddxmmxyy, mmcddcyy, ddcmmcyy }
        public enum LongTime { EightThirthy, ThirtyMinutesPastEight, EightThirtyandTwentySeconds, EightMinutesandTwentySecondsPastEight }
        public enum LongDate { xxdaymmddyyyy, mmddyyyy, mmdd, ddmmyyyy }

        // DateData is an XRUIOS type (XRUIOS.Barebones namespace) — represented as DiracPackage over the wire
        public static async Task<DiracResponse?> SetCurrentDate(DiracPackage newDate)
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.SetCurrentDate", ("newDate", newDate));

        public static async Task<DiracPackage?> GetCurrentDate()
            => await EclipseClient.InvokeAsync<DiracPackage>("Chrono.GetCurrentDate");

        public static async Task<DiracResponse?> SaveDateData()
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.SaveDateData");

        public static async Task<DiracResponse?> LoadDateData()
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.LoadDateData");

        public static async Task<string?> GetTimezone(string Timezone)
            => await EclipseClient.InvokeAsync<string>("Chrono.GetTimezone", ("Timezone", Timezone));

        public static async Task<DiracResponse?> SetTimezone(string Timezone)
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.SetTimezone", ("Timezone", Timezone));

        public static async Task<ValueTuple<string, string>?> GetDate()
            => await EclipseClient.InvokeAsync<ValueTuple<string, string>>("Chrono.GetDate");

        public static async Task<DiracResponse?> SetDate(ShortDate shortDateFormat, LongDate longDateFormat)
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.SetDate",
                ("shortDateFormat", shortDateFormat), ("longDateFormat", longDateFormat));

        public static async Task<ValueTuple<string, string>?> GetTime()
            => await EclipseClient.InvokeAsync<ValueTuple<string, string>>("Chrono.GetTime");

        public static async Task<DiracResponse?> SetTime(ShortTime shortTimeFormat, LongTime longTimeFormat)
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.SetTime",
                ("shortTimeFormat", shortTimeFormat), ("longTimeFormat", longTimeFormat));

        public static async Task<DiracResponse?> AddWorldTime(string worldTime)
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.AddWorldTime", ("worldTime", worldTime));

        public static async Task<List<string>?> GetWorldTimezoneCollection()
            => await EclipseClient.InvokeAsync<List<string>>("Chrono.GetWorldTimezoneCollection");

        public static async Task<List<Dictionary<string, ValueTuple<string, string, string, string>>>?> GetWorldTimes()
            => await EclipseClient.InvokeAsync<List<Dictionary<string, ValueTuple<string, string, string, string>>>>("Chrono.GetWorldTimes");

        public static async Task<ValueTuple<string, string, string, string>?> GetTimeInTimezone(string timeZoneData)
            => await EclipseClient.InvokeAsync<ValueTuple<string, string, string, string>>("Chrono.GetTimeInTimezone", ("timeZoneData", timeZoneData));

        public static async Task<DiracResponse?> DeleteWorldTime(string worldTime)
            => await EclipseClient.InvokeAsync<DiracResponse>("Chrono.DeleteWorldTime", ("worldTime", worldTime));

        public class NumberConvert
        {
            public static async Task<string?> NumberToWords(long number)
                => await EclipseClient.InvokeAsync<string>("Chrono.NumberConvert.NumberToWords", ("number", number));
        }

        public class MonthConverter
        {
            public static async Task<string?> ConvertToWordedMonth(int monthNumber)
                => await EclipseClient.InvokeAsync<string>("Chrono.MonthConverter.ConvertToWordedMonth", ("monthNumber", monthNumber));
        }
    }
}
