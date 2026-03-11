using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class StopwatchClass
    {
        // StopwatchRecord (XRUIOS): { int LapCount, int SecondsElapsed }
        public static async Task<string?> CreateStopwatch()
            => await EclipseClient.InvokeAsync<string>("StopwatchClass.CreateStopwatch");

        public static async Task<string?> CreateStopwatch(string name)
            => await EclipseClient.InvokeAsync<string>("StopwatchClass.CreateStopwatch", ("name", name));

        public static async Task<ValueTuple<int, List<string>>?> GetActiveStopwatches()
            => await EclipseClient.InvokeAsync<ValueTuple<int, List<string>>>("StopwatchClass.GetActiveStopwatches");

        public static async Task<TimeSpan?> GetTimeElapsed(string id)
            => await EclipseClient.InvokeAsync<TimeSpan>("StopwatchClass.GetTimeElapsed", ("id", id));

        public static async Task<DiracResponse?> PauseStopwatch(string id)
            => await EclipseClient.InvokeAsync<DiracResponse>("StopwatchClass.PauseStopwatch", ("id", id));

        public static async Task<DiracResponse?> ResumeStopwatch(string id)
            => await EclipseClient.InvokeAsync<DiracResponse>("StopwatchClass.ResumeStopwatch", ("id", id));

        public static async Task<bool?> IsStopwatchRunning(string id)
            => await EclipseClient.InvokeAsync<bool>("StopwatchClass.IsStopwatchRunning", ("id", id));

        public static async Task<DiracPackage?> CreateLap(string id)
            => await EclipseClient.InvokeAsync<DiracPackage>("StopwatchClass.CreateLap", ("id", id));

        public static async Task<DiracPackage?> DestroyStopwatch(string id)
            => await EclipseClient.InvokeAsync<DiracPackage>("StopwatchClass.DestroyStopwatch", ("id", id));

        public static async Task<DiracResponse?> SaveStopwatchValuesAsSheet(DiracPackage Values, DateTime RecordedOn, string FileName)
            => await EclipseClient.InvokeAsync<DiracResponse>("StopwatchClass.SaveStopwatchValuesAsSheet",
                ("Values", Values), ("RecordedOn", RecordedOn), ("FileName", FileName));
    }
}
