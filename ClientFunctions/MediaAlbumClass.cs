using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class MediaAlbumClass
    {
        // AlbumMedia is in XRUIOS.Barebones.Interfaces.MediaAlbumClass namespace → XRUIOS type → DiracPackage

        public static async Task<DiracResponse?> AddMediaAlbum(DiracPackage MediaAlbum)
            => await EclipseClient.InvokeAsync<DiracResponse>("MediaAlbumClass.AddMediaAlbum", ("MediaAlbum", MediaAlbum));

        public static async Task<DiracPackage?> GetMediaAlbums()
            => await EclipseClient.InvokeAsync<DiracPackage>("MediaAlbumClass.GetMediaAlbums");

        public static async Task<DiracPackage?> GetMediaAlbum(string identifier)
            => await EclipseClient.InvokeAsync<DiracPackage>("MediaAlbumClass.GetMediaAlbum", ("identifier", identifier));

        public static async Task<DiracResponse?> UpdateMediaAlbum(DiracPackage MediaAlbum)
            => await EclipseClient.InvokeAsync<DiracResponse>("MediaAlbumClass.UpdateMediaAlbum", ("MediaAlbum", MediaAlbum));

        public static async Task<DiracResponse?> DeleteMediaAlbum(string identifier)
            => await EclipseClient.InvokeAsync<DiracResponse>("MediaAlbumClass.DeleteMediaAlbum", ("identifier", identifier));
    }

    public class MediaAlbumFavoritesClass
    {
        public static async Task<DiracResponse?> AddToFavorites(string MediaAlbumIdentifier, string directoryUUID)
            => await EclipseClient.InvokeAsync<DiracResponse>("MediaAlbumFavoritesClass.AddToFavorites",
                ("MediaAlbumIdentifier", MediaAlbumIdentifier), ("directoryUUID", directoryUUID));

        public static async Task<ValueTuple<List<string>, List<string>>?> GetFavorites()
            => await EclipseClient.InvokeAsync<ValueTuple<List<string>, List<string>>>("MediaAlbumFavoritesClass.GetFavorites");

        public static async Task<List<string>?> GetFavoritePathsAsync(bool onlyResolved)
            => await EclipseClient.InvokeAsync<List<string>>("MediaAlbumFavoritesClass.GetFavoritePathsAsync",
                ("onlyResolved", onlyResolved));

        public static async Task<DiracResponse?> RemoveFromFavorites(string MediaAlbumIdentifier, string directoryUUID)
            => await EclipseClient.InvokeAsync<DiracResponse>("MediaAlbumFavoritesClass.RemoveFromFavorites",
                ("MediaAlbumIdentifier", MediaAlbumIdentifier), ("directoryUUID", directoryUUID));
    }
}
