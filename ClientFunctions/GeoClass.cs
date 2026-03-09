using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class GeoClass
    {
        
        public static async Task<DiracPackage?> GetExactCoordinates()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("GeoClass.GetExactCoordinates");
        }

        
        public static async Task<DiracPackage?> GetRecentLocations()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("GeoClass.GetRecentLocations");
        }

        
        public static async Task<DiracResponse?> ClearLocationHistory(DiracPackage newLocation)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("GeoClass.ClearLocationHistory",
                ("newLocation", newLocation));
        }

        
        public static async Task<DiracPackage?> GetRelativeCoordinates()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("GeoClass.GetRelativeCoordinates");
        }

        
        public static async Task<DiracPackage?> ConvertToRelativeCoordinates(double latitude, double longitude)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("GeoClass.ConvertToRelativeCoordinates",
                ("latitude", latitude),
                ("longitude", longitude));
        }

        
        public static async Task<DiracPackage?> GetRecentRelativeLocations()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("GeoClass.GetRecentRelativeLocations");
        }

        
        public static async Task<DiracResponse?> ClearRelativeLocationHistory(DiracPackage newLocation)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("GeoClass.ClearRelativeLocationHistory",
                ("newLocation", newLocation));
        }

        
        public static async Task<DiracResponse?> AddVirtualPoint(double latitude, double longitude, string virtualLocation)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("GeoClass.AddVirtualPoint",
                ("latitude", latitude),
                ("longitude", longitude),
                ("virtualLocation", virtualLocation));
        }

        
        public static async Task<DiracPackage?> GetVirtualRelativeLocations(string virtualLocation)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("GeoClass.GetVirtualRelativeLocations",
                ("virtualLocation", virtualLocation));
        }

        
        public static async Task<DiracResponse?> ClearVirtualLocationHistory(DiracPackage newLocation, string virtualLocation)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("GeoClass.ClearVirtualLocationHistory",
                ("newLocation", newLocation),
                ("virtualLocation", virtualLocation));
        }
    }
}
