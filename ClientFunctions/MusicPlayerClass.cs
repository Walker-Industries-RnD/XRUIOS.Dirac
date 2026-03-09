using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class MusicPlayerClass
    {
        public static class CurrentlyPlayingClass
        {
        }

        public static class MusicQueueClass
        {
        }

        
        public static async Task<DiracPackage?> GetOrCreateOverview(string audioFile, string directoryUUID)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("MusicPlayerClass.GetOrCreateOverview",
                ("audioFile", audioFile),
                ("directoryUUID", directoryUUID));
        }

        public static class Random { }
    }
}
