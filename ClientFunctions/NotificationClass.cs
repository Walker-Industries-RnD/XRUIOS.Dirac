using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class NotificationClass
    {
        
        public static async Task<DiracResponse?> AddNotification(DiracPackage notification)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NotificationClass.AddNotification",
                ("notification", notification));
        }

        
        public static async Task<DiracPackage?> GetNotifications(bool includeExpired)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("NotificationClass.GetNotifications",
                ("includeExpired", includeExpired));
        }

        
        public static async Task<DiracResponse?> RemoveNotification(string tag, string group)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NotificationClass.RemoveNotification",
                ("tag", tag),
                ("group", group));
        }

        
        public static async Task<DiracResponse?> ClearAllNotifications()
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NotificationClass.ClearAllNotifications");
        }
    }
}
