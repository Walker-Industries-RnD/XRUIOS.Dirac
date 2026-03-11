using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class ProcessesClass
    {
        
        public static async Task<DiracPackage?> GetCurrentProcesses(bool includeCpu)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("ProcessesClass.GetCurrentProcesses",
                ("includeCpu", includeCpu));
        }

        
        public static async Task<string?> SaveProcessSnapshot(string? snapshotName)
        {
            return await EclipseClient.InvokeAsync<string>("ProcessesClass.SaveProcessSnapshot",
                ("snapshotName", snapshotName));
        }

        
        public static async Task<List<string>?> GetSavedSnapshots()
        {
            return await EclipseClient.InvokeAsync<List<string>>("ProcessesClass.GetSavedSnapshots");
        }

        
        public static async Task<DiracPackage?> LoadProcessSnapshot(string snapshotFileName)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("ProcessesClass.LoadProcessSnapshot",
                ("snapshotFileName", snapshotFileName));
        }

        
        public static async Task<DiracPackage?> GetProcessesByType()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("ProcessesClass.GetProcessesByType");
        }

        
        public static async Task<bool?> KillProcess(int processId, string processName)
        {
            return await EclipseClient.InvokeAsync<bool>("ProcessesClass.KillProcess",
                ("processId", processId),
                ("processName", processName));
        }
    }
}
