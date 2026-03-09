using System.Collections.Generic;
using System.Threading.Tasks;
using EclipseLCL;
using EclipseProject;

namespace ClientFunctions
{
    public class AreaManagerClass
    {
        public enum PositionalTrackingMode { Follow, Anchored, FollowingExternal }
        public enum RotationalTrackingMode { Static, LAM }
        public enum ObjectOSLabel { Default, Software, Objects, Voice, WorldPoint, Alerts, Ui, Other }
        public enum RenderingMode { OnlyWhenVisible, AllFrames }

        // FileRecord (YuukoProtocol): { string UUID, string File }

        // WorldPoint, StaticObject, App, DesktopScreen, StaciaItems are in XRUIOS.Barebones.Functions namespace
        // → XRUIOS types → DiracPackage over the wire

        public static async Task<DiracPackage?> UpdateWorldPoint(DiracPackage wp, DiracPackage patch)
            => await EclipseClient.InvokeAsync<DiracPackage>("Area Manager.UpdateWorldPoint", ("wp", wp), ("patch", patch));

        public static async Task<DiracPackage?> UpdateStaticObject(DiracPackage obj, DiracPackage patch)
            => await EclipseClient.InvokeAsync<DiracPackage>("Area Manager.UpdateStaticObject", ("obj", obj), ("patch", patch));

        public static async Task<DiracPackage?> UpdateApp(DiracPackage obj, DiracPackage patch)
            => await EclipseClient.InvokeAsync<DiracPackage>("Area Manager.UpdateApp", ("obj", obj), ("patch", patch));

        public static async Task<DiracPackage?> UpdateDesktopScreen(DiracPackage obj, DiracPackage patch)
            => await EclipseClient.InvokeAsync<DiracPackage>("Area Manager.UpdateDesktopScreen", ("obj", obj), ("patch", patch));

        public static async Task<DiracPackage?> UpdateStaciaItems(DiracPackage obj, DiracPackage patch)
            => await EclipseClient.InvokeAsync<DiracPackage>("Area Manager.UpdateStaciaItems", ("obj", obj), ("patch", patch));

        public static async Task<DiracResponse?> AddWorldPoint(DiracPackage worldPoint)
            => await EclipseClient.InvokeAsync<DiracResponse>("Area Manager.AddWorldPoint", ("worldPoint", worldPoint));

        public static async Task<List<string>?> GetWorldPoints()
            => await EclipseClient.InvokeAsync<List<string>>("Area Manager.GetWorldPoints");

        public static async Task<DiracPackage?> GetWorldPoint(string identifier)
            => await EclipseClient.InvokeAsync<DiracPackage>("Area Manager.GetWorldPoint", ("identifier", identifier));

        public static async Task<DiracResponse?> UpdateWorldPoint(DiracPackage worldPoint)
            => await EclipseClient.InvokeAsync<DiracResponse>("Area Manager.UpdateWorldPoint", ("worldPoint", worldPoint));

        public static async Task<DiracResponse?> DeleteWorldPoint(string identifier)
            => await EclipseClient.InvokeAsync<DiracResponse>("Area Manager.DeleteWorldPoint", ("identifier", identifier));
    }
}
