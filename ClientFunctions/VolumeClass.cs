using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class VolumeClass
    {
        
        public static async Task<DiracPackage?> GetCurrentVolumeSettings()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("VolumeClass.GetCurrentVolumeSettings");
        }

        
        public static async Task<DiracResponse?> SetCurrentVolumeSettings(DiracPackage soundSetting)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("VolumeClass.SetCurrentVolumeSettings",
                ("soundSetting", soundSetting));
        }

        
        public static async Task<DiracResponse?> AddVolumeSettings(DiracPackage VolumeMixings)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("VolumeClass.AddVolumeSettings",
                ("VolumeMixings", VolumeMixings));
        }

        
        public static async Task<DiracPackage?> GetVolumeSettings()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("VolumeClass.GetVolumeSettings");
        }

        
        public static async Task<DiracPackage?> GetVolumeSetting(string volumeSettingName)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("VolumeClass.GetVolumeSetting",
                ("volumeSettingName", volumeSettingName));
        }

        
        public static async Task<DiracPackage?> GetVolumeSettingsForThisDevice()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("VolumeClass.GetVolumeSettingsForThisDevice");
        }

        
        public static async Task<DiracResponse?> UpdateVolumeSettingDB(DiracPackage originalData, DiracPackage newData)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("VolumeClass.UpdateVolumeSettingDB",
                ("originalData", originalData),
                ("newData", newData));
        }

        
        public static async Task<DiracResponse?> DeleteVolumeSettingDB(DiracPackage deletedData)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("VolumeClass.DeleteVolumeSettingDB",
                ("deletedData", deletedData));
        }

        
        public static async Task<DiracResponse?> ClearEQDB()
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("VolumeClass.ClearEQDB");
        }
    }
}
