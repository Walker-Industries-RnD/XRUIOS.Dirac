using EclipseProject;
using EclipseLCL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class DataManagerClass
    {
        public static class SessionClass
        {
            
            public static async Task<DiracResponse?> AddSession(DiracPackage session)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.SessionClass.AddSession",
                    ("Session", session));
            }

            
            public static async Task<List<string>?> GetSession()
            {
                return await EclipseClient.InvokeAsync<List<string>>("DataManagerClass.SessionClass.GetSession");
            }

            
            public static async Task<DiracPackage?> GetSession(string id)
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("DataManagerClass.SessionClass.GetSession",
                    ("identifier", id));
            }

            
            public static async Task<DiracResponse?> UpdateSession(DiracPackage session)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.SessionClass.UpdateSession",
                    ("Session", session));
            }

            
            public static async Task<DiracResponse?> DeleteSession(string id)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.SessionClass.DeleteSession",
                    ("identifier", id));
            }

            
            public static async Task<DiracResponse?> InitiateSession(string id)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.SessionClass.InitiateSession",
                    ("identifier", id));
            }
        }

        public static class DataSlotClass
        {

            
            public static async Task<DiracResponse?> AddDataSlot(DiracPackage dataSlot)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.DataSlotClass.AddDataSlot",
                    ("DataSlot", dataSlot));
            }

            
            public static async Task<List<string>?> GetDataSlot()
            {
                return await EclipseClient.InvokeAsync<List<string>>("DataManagerClass.DataSlotClass.GetDataSlot");
            }

            
            public static async Task<DiracPackage?> GetDataSlot(string id)
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("DataManagerClass.DataSlotClass.GetDataSlot",
                    ("identifier", id));
            }

            
            public static async Task<DiracResponse?> UpdateDataSlot(DiracPackage dataSlot)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.DataSlotClass.UpdateDataSlot",
                    ("DataSlot", dataSlot));
            }

            
            public static async Task<DiracResponse?> DeleteDataSlot(string id)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.DataSlotClass.DeleteDataSlot",
                    ("identifier", id));
            }

            
            public static async Task<DiracResponse?> InitiateDataSlot(string id)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.DataSlotClass.InitiateDataSlot",
                    ("identifier", id));
            }
        }

        // FileRecord (YuukoProtocol): { string UUID, string File }

        public class DataSlotFavoritesClass
        {
            
            public async Task<DiracResponse?> AddToFavorites(string dataSlotIdentifier, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.DataSlotFavoritesClass.AddToFavorites",
                    ("dataSlotIdentifier", dataSlotIdentifier),
                    ("directoryUUID", directoryUUID));
            }

            
            public async Task<ValueTuple<List<string>, List<string>>?> GetFavorites()
            {
                return await EclipseClient.InvokeAsync<ValueTuple<List<string>, List<string>>>("DataManagerClass.DataSlotFavoritesClass.GetFavorites");
            }

            
            public async Task<List<string>?> GetFavoritePathsAsync(bool onlyResolved)
            {
                return await EclipseClient.InvokeAsync<List<string>>("DataManagerClass.DataSlotFavoritesClass.GetFavoritePathsAsync",
                    ("onlyResolved", onlyResolved));
            }

            
            public async Task<DiracResponse?> RemoveFromFavorites(string dataSlotIdentifier, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("DataManagerClass.DataSlotFavoritesClass.RemoveFromFavorites",
                    ("dataSlotIdentifier", dataSlotIdentifier),
                    ("directoryUUID", directoryUUID));
            }
        }

        public static class Current
        {
            // ObservableProperty<T> (XRUIOS): an observable wrapper around T that notifies listeners on value change
            public static DiracPackage? CurrentSession;
        }
    }
}
