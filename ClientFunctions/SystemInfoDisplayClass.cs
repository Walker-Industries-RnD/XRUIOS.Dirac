using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class SystemInfoDisplayClass
    {
        public static class SystemInfoDisplayWindows
        {
            
            public static async Task<DiracPackage?> GenerateSpecs()
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GenerateSpecs");
            }

            
            public static async Task<string?> GetOSInfo()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GetOSInfo");
            }

            
            public static async Task<string?> GetCPUInfo()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GetCPUInfo");
            }

            
            public static async Task<string?> GetMemoryInfo()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GetMemoryInfo");
            }

            
            public static async Task<string?> GetDiskInfo()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GetDiskInfo");
            }

            
            public static async Task<string?> GetGPUInfo()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GetGPUInfo");
            }

            
            public static async Task<string?> GetNetworkInfo()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GetNetworkInfo");
            }

            
            public static async Task<string?> GetUptimeInfo()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.GetUptimeInfo");
            }

            
            public static async Task<string?> CheckHardware()
            {
                return await EclipseClient.InvokeAsync<string>("SystemInfoDisplayClass.SystemInfoDisplayWindows.CheckHardware");
            }
        }
    }
}
