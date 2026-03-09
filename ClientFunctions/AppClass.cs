using System.Threading.Tasks;
using EclipseLCL;
using EclipseProject;

namespace ClientFunctions
{
    public class AppClass
    {
        // XRUIOSAppManifest and XRUIOSAppManifestPatch are XRUIOS types — DiracPackage over the wire

        public static async Task<DiracPackage?> UpdateApp(DiracPackage app, DiracPackage patch)
            => await EclipseClient.InvokeAsync<DiracPackage>("App.UpdateApp", ("app", app), ("patch", patch));

        public static async Task<DiracResponse?> AddApp(DiracPackage App)
            => await EclipseClient.InvokeAsync<DiracResponse>("App.AddApp", ("App", App));

        public static async Task<DiracPackage?> GetApp()
            => await EclipseClient.InvokeAsync<DiracPackage>("App.GetApp");

        public static async Task<DiracPackage?> GetApp(string identifier)
            => await EclipseClient.InvokeAsync<DiracPackage>("App.GetApp", ("identifier", identifier));

        public static async Task<DiracResponse?> UpdateApp(DiracPackage App)
            => await EclipseClient.InvokeAsync<DiracResponse>("App.UpdateApp", ("App", App));

        public static async Task<DiracResponse?> DeleteApp(string identifier)
            => await EclipseClient.InvokeAsync<DiracResponse>("App.DeleteApp", ("identifier", identifier));
    }
}
