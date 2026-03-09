using System.Threading.Tasks;
using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;

namespace ClientFunctions
{
    public class AlarmClass
    {
        // FileRecord (YuukoProtocol): { string UUID, string File }

        public static async Task<DiracResponse?> AddAlarm(DiracPackage newAlarm)
            => await EclipseClient.InvokeAsync<DiracResponse>("Alarm.AddAlarm", ("newAlarm", newAlarm));

        public static async Task<DiracResponse?> LoadAlarms()
            => await EclipseClient.InvokeAsync<DiracResponse>("Alarm.LoadAlarms");

        public static async Task<DiracResponse?> CreateAlarm(string alarmName, DateTime alarmTime, bool isRecurring, List<DayOfWeek> recurringDays, DiracPackage soundFilePath, int volume)
            => await EclipseClient.InvokeAsync<DiracResponse>("Alarm.CreateAlarm",
                ("alarmName", alarmName), ("alarmTime", alarmTime), ("isRecurring", isRecurring),
                ("recurringDays", recurringDays), ("soundFilePath", soundFilePath), ("volume", volume));

        public static async Task<DiracPackage?> GetAlarmDetails(string alarmName)
            => await EclipseClient.InvokeAsync<DiracPackage>("Alarm.GetAlarmDetails", ("alarmName", alarmName));

        public static async Task<DiracPackage?> SearchAlarms(string query)
            => await EclipseClient.InvokeAsync<DiracPackage>("Alarm.SearchAlarms", ("query", query));

        public static async Task<ValueTuple<string, string>?> GetCurrentTime()
            => await EclipseClient.InvokeAsync<ValueTuple<string, string>>("Alarm.GetCurrentTime");

        public static async Task<string?> GetCurrentTimezone()
            => await EclipseClient.InvokeAsync<string>("Alarm.GetCurrentTimezone");

        public static async Task<DiracResponse?> SetTimezone(string timezone)
            => await EclipseClient.InvokeAsync<DiracResponse>("Alarm.SetTimezone", ("timezone", timezone));

        public static async Task<DiracResponse?> DeleteAlarm(DiracPackage alarm)
            => await EclipseClient.InvokeAsync<DiracResponse>("Alarm.DeleteAlarm", ("alarm", alarm));
    }
}
