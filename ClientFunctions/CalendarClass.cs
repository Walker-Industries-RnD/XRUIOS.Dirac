using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class CalendarClass
    {
        // FileRecord (YuukoProtocol): { string UUID, string File }
        // CalendarEvent (XRUIOS): { string Uid, string Summary, string Description, DateTime EventDate, TimeSpan Duration, RecurrencePattern? Recurrence, List<FileRecord> Attachments }
        // RecurrencePattern (XRUIOS): { string Frequency, int Interval, List<DayOfWeek> ByDay, DateTime? Until, int? Count }
        // Occurrence (XRUIOS): { CalendarEvent Event, DateTime OccurrenceDate }

        public static async Task<string?> CreateSimpleEvent(DateTime eventDate, string summary, string description, TimeZoneInfo timezone, int durationHours, DiracPackage attachmentsList)
            => await EclipseClient.InvokeAsync<string>("Calendar.CreateSimpleEvent",
                ("eventDate", eventDate), ("summary", summary), ("description", description),
                ("timezone", timezone), ("durationHours", durationHours), ("attachmentsList", attachmentsList));

        public static async Task<string?> CreateRecurringEvent(DateTime eventDate, string summary, string description, DiracPackage recurrencePattern, TimeZoneInfo timezone, int durationHours, DiracPackage attachmentsList)
            => await EclipseClient.InvokeAsync<string>("Calendar.CreateRecurringEvent",
                ("eventDate", eventDate), ("summary", summary), ("description", description),
                ("recurrencePattern", recurrencePattern), ("timezone", timezone),
                ("durationHours", durationHours), ("attachmentsList", attachmentsList));

        public static async Task<DiracPackage?> LoadAllEvents()
            => await EclipseClient.InvokeAsync<DiracPackage>("Calendar.LoadAllEvents");

        public static async Task<DiracPackage?> GetEventsForDay(DateTime day)
            => await EclipseClient.InvokeAsync<DiracPackage>("Calendar.GetEventsForDay", ("day", day));

        public static async Task<DiracPackage?> GetEventsInRange(DateTime start, DateTime end)
            => await EclipseClient.InvokeAsync<DiracPackage>("Calendar.GetEventsInRange", ("start", start), ("end", end));

        public static async Task<DiracPackage?> GetEventByUid(string uid)
            => await EclipseClient.InvokeAsync<DiracPackage>("Calendar.GetEventByUid", ("uid", uid));

        public static async Task<DiracResponse?> DeleteEventByUid(string uid)
            => await EclipseClient.InvokeAsync<DiracResponse>("Calendar.DeleteEventByUid", ("uid", uid));

        public static async Task<DiracResponse?> ScheduleUpcomingOccurrences(DiracPackage upcomingOccurrences, TimeSpan lookaheadWindow)
            => await EclipseClient.InvokeAsync<DiracResponse>("Calendar.ScheduleUpcomingOccurrences",
                ("upcomingOccurrences", upcomingOccurrences), ("lookaheadWindow", lookaheadWindow));
    }
}
