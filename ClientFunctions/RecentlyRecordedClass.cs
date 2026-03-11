using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class RecentlyRecordedClass
    {
        // FileRecord (YuukoProtocol): { string UUID, string File }

        public static async Task<DiracPackage?> GetRecentlyRecorded()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("RecentlyRecordedClass.GetRecentlyRecorded");
        }

        
        public static async Task<DiracResponse?> AddToRecentlyRecorded(DiracPackage newlyRecorded)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("RecentlyRecordedClass.AddToRecentlyRecorded",
                ("newlyRecorded", newlyRecorded));
        }

        
        public static async Task<DiracResponse?> DeleteSoundRecentlyRecorded(DiracPackage deletedData)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("RecentlyRecordedClass.DeleteSoundRecentlyRecorded",
                ("deletedData", deletedData));
        }

        
        public static async Task<DiracResponse?> ClearRecentlyRecorded()
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("RecentlyRecordedClass.ClearRecentlyRecorded");
        }
    }
}
