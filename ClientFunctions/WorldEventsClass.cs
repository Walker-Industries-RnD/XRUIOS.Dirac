using EclipseLCL;
using EclipseProject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class WorldEventsClass
    {
        // WorldEvent is an XRUIOS type (XRUIOS.Barebones.Interfaces namespace) — represented as DiracPackage over the wire

        public static async Task<DiracPackage?> GetWorldEvents()
            => await EclipseClient.InvokeAsync<DiracPackage>("WorldEventsClass.GetWorldEvents");

        public static async Task<DiracResponse?> AddWorldEvent(DiracPackage newEvent)
            => await EclipseClient.InvokeAsync<DiracResponse>("WorldEventsClass.AddWorldEvent", ("newEvent", newEvent));

        public static async Task<DiracResponse?> DeleteWorldEvent(DiracPackage deletedEvent)
            => await EclipseClient.InvokeAsync<DiracResponse>("WorldEventsClass.DeleteWorldEvent", ("deletedEvent", deletedEvent));

        public static async Task<DiracResponse?> ClearWorldEvents()
            => await EclipseClient.InvokeAsync<DiracResponse>("WorldEventsClass.ClearWorldEvents");
    }
}
