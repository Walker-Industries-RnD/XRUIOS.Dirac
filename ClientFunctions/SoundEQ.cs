using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class SoundEQClass
    {
        
        public static async Task<DiracPackage?> GetCurrentEQ()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("SoundEQClass.GetCurrentEQ");
        }

        
        public static async Task<DiracResponse?> SetCurrentEQ(DiracPackage soundSetting)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("SoundEQClass.SetCurrentEQ",
                ("soundSetting", soundSetting));
        }

        
        public static async Task<DiracResponse?> AddSoundEQDBs(DiracPackage EQDBData)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("SoundEQClass.AddSoundEQDBs",
                ("EQDBData", EQDBData));
        }

        
        public static async Task<DiracPackage?> GetSoundEQDBs()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("SoundEQClass.GetSoundEQDBs");
        }

        
        public static async Task<DiracPackage?> GetSoundEQDB(string eqDBName)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("SoundEQClass.GetSoundEQDB",
                ("eqDBName", eqDBName));
        }

        
        public static async Task<DiracResponse?> UpdateSoundEQDB(DiracPackage originalData, DiracPackage newData)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("SoundEQClass.UpdateSoundEQDB",
                ("originalData", originalData),
                ("newData", newData));
        }

        
        public static async Task<DiracResponse?> DeleteSoundEQDB(DiracPackage deletedData)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("SoundEQClass.DeleteSoundEQDB",
                ("deletedData", deletedData));
        }

        
        public static async Task<DiracResponse?> ClearEQDB()
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("SoundEQClass.ClearEQDB");
        }

        
        public static async Task<DiracResponse?> SetDefaultEQDB(DiracPackage EQDBData)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("SoundEQClass.SetDefaultEQDB",
                ("EQDBData", EQDBData));
        }

        
        public static async Task<DiracPackage?> GetDefaultEQDB()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("SoundEQClass.GetDefaultEQDB");
        }

        
        public static async Task<DiracResponse?> ResetDefaultEQDB()
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("SoundEQClass.ResetDefaultEQDB");
        }
    }
}
