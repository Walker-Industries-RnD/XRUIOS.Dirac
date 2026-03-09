using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class TimerManagerClass
    {
        // TimerRecord is an XRUIOS type (XRUIOS.Barebones.Interfaces namespace) — represented as DiracPackage over the wire

        public static async Task<DiracResponse?> StartTimer(DiracPackage timer)
            => await EclipseClient.InvokeAsync<DiracResponse>("TimerManagerClass.StartTimer", ("timer", timer));

        public static async Task<DiracResponse?> AddTime(string timerName, TimeSpan extra)
            => await EclipseClient.InvokeAsync<DiracResponse>("TimerManagerClass.AddTime", ("timerName", timerName), ("extra", extra));

        public static async Task<DiracResponse?> CancelTimer(string timerName)
            => await EclipseClient.InvokeAsync<DiracResponse>("TimerManagerClass.CancelTimer", ("timerName", timerName));

        // CreateTimer skipped — has Action parameter that cannot be serialized over the wire

        public static async Task<DiracResponse?> PauseTimer(string timerName)
            => await EclipseClient.InvokeAsync<DiracResponse>("TimerManagerClass.PauseTimer", ("timerName", timerName));

        public static async Task<DiracResponse?> ResumeTimer(string timerName)
            => await EclipseClient.InvokeAsync<DiracResponse>("TimerManagerClass.ResumeTimer", ("timerName", timerName));

        public static async Task<bool?> IsTimerRunning(string timerName)
            => await EclipseClient.InvokeAsync<bool>("TimerManagerClass.IsTimerRunning", ("timerName", timerName));

        public static async Task<DiracResponse?> FireTimer(string timerName)
            => await EclipseClient.InvokeAsync<DiracResponse>("TimerManagerClass.FireTimer", ("timerName", timerName));
    }
}
