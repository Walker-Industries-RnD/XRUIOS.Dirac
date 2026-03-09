using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class ThemeSystem
    {
        
        public static async Task<DiracResponse?> SaveTheme(DiracPackage theme)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("ThemeSystem.SaveTheme",
                ("theme", theme));
        }

        
        public static async Task<DiracPackage?> GetAllXRUIOSThemes()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("ThemeSystem.GetAllXRUIOSThemes");
        }

        
        public static async Task<DiracPackage?> GetXRUIOSTheme(string FileName)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("ThemeSystem.GetXRUIOSTheme",
                ("FileName", FileName));
        }

        
        public static async Task<DiracPackage?> GetCurrentTheme(string FileName)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("ThemeSystem.GetCurrentTheme",
                ("FileName", FileName));
        }

        
        public static async Task<DiracResponse?> UpdateTheme(DiracPackage theme, DiracPackage newTheme)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("ThemeSystem.UpdateTheme",
                ("theme", theme),
                ("newTheme", newTheme));
        }

        
        public static async Task<DiracResponse?> SetTheme(string FileName)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("ThemeSystem.SetTheme",
                ("FileName", FileName));
        }

        
        public static async Task<DiracResponse?> DeleteXRUIOSTheme(string FileName)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("ThemeSystem.DeleteXRUIOSTheme",
                ("FileName", FileName));
        }
    }
}
