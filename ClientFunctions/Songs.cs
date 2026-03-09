using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ClientFunctions
{
    public class Songs
    {
        public enum MusicInfoStyle { overview, detailed, both }

        public enum SongSearchField
        {
            SongName,
            AlbumName,
            TrackArtist,
            AlbumArtist,
            Genre,
            ISRC,
            Comment,
        }

        public class SongClass
        {
            
            public static async Task<DiracResponse?> CreateSongInfo(string audioFile, string directoryUUID, bool autoTag = false)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongClass.CreateSongInfo",
                    ("audioFile", audioFile),
                    ("directoryUUID", directoryUUID),
                    ("autoTag", autoTag));
            }

            
            public static async Task<DiracPackage?> GetSongInfo(string audioFile, string directoryUUID, MusicInfoStyle getData, bool autoCreateIfMissing = true, bool autoTagIfMissing = true)
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.SongClass.GetSongInfo",
                    ("audioFile", audioFile),
                    ("directoryUUID", directoryUUID),
                    ("getData", getData),
                    ("autoCreateIfMissing", autoCreateIfMissing),
                    ("autoTagIfMissing", autoTagIfMissing));
            }

            
            public static async Task<DiracResponse?> UpdateSongInfo(string audioFile, string directoryUUID, DiracPackage patch, MusicInfoStyle mode = MusicInfoStyle.both, bool forceReParseFromAudio = false)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongClass.UpdateSongInfo",
                    ("audioFile", audioFile),
                    ("directoryUUID", directoryUUID),
                    ("patch", patch),
                    ("mode", mode),
                    ("forceReParseFromAudio", forceReParseFromAudio));
            }

            
            public static async Task<DiracResponse?> DeleteSongInfo(string audioFile, string directoryUUID, bool deleteSong = true)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongClass.DeleteSongInfo",
                    ("audioFile", audioFile),
                    ("directoryUUID", directoryUUID),
                    ("deleteSong", deleteSong));
            }
        }

        public class SongDirectoriesClass
        {
            
            public static async Task<DiracResponse?> AddSongDirectory(string directory, string directoryName)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongDirectoriesClass.AddSongDirectory",
                    ("directory", directory),
                    ("directoryName", directoryName));
            }

            
            public static async Task<DiracPackage?> GetSongDirectories()
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.SongDirectoriesClass.GetSongDirectories");
            }

            
            public static async Task<List<string>?> GetSongDirectoryPaths(bool onlyResolved = true)
            {
                return await EclipseClient.InvokeAsync<List<string>>("Songs.SongDirectoriesClass.GetSongDirectoryPaths",
                    ("onlyResolved", onlyResolved));
            }

            
            public static async Task<DiracResponse?> UpdateSongDirectory(string uuid, string newDirectory, string newDirectoryName)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongDirectoriesClass.UpdateSongDirectory",
                    ("uuid", uuid),
                    ("newDirectory", newDirectory),
                    ("newDirectoryName", newDirectoryName));
            }

            
            public static async Task<DiracResponse?> RemoveSongDirectory(string uuid, bool deleteDirectory = false)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongDirectoriesClass.RemoveSongDirectory",
                    ("uuid", uuid),
                    ("deleteDirectory", deleteDirectory));
            }
        }

        public class SongFavoritesClass
        {
            
            public static async Task<DiracResponse?> AddToFavorites(string audioFileName, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongFavoritesClass.AddToFavorites",
                    ("audioFileName", audioFileName),
                    ("directoryUUID", directoryUUID));
            }

            
            public static async Task<DiracPackage?> GetFavorites()
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.SongFavoritesClass.GetFavorites");
            }

            
            public static async Task<List<string>?> GetFavoritePathsAsync(bool onlyResolved = true)
            {
                return await EclipseClient.InvokeAsync<List<string>>("Songs.SongFavoritesClass.GetFavoritePathsAsync",
                    ("onlyResolved", onlyResolved));
            }

            
            public static async Task<DiracResponse?> RemoveFromFavorites(string audioFileName, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.SongFavoritesClass.RemoveFromFavorites",
                    ("audioFileName", audioFileName),
                    ("directoryUUID", directoryUUID));
            }
        }

        public class SongGetClass
        {
            
            public static async Task<DiracPackage?> GetAllSongs(bool onlyFavorites = false)
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.SongGetClass.GetAllSongs",
                    ("onlyFavorites", onlyFavorites));
            }

            
            public static async Task<List<string>?> GetAllSongPaths(bool onlyResolved = true, bool onlyFavorites = false)
            {
                return await EclipseClient.InvokeAsync<List<string>>("Songs.SongGetClass.GetAllSongPaths",
                    ("onlyResolved", onlyResolved),
                    ("onlyFavorites", onlyFavorites));
            }

            
            public static async Task<DiracPackage?> GetSongsInDirectoryAsync(string directoryUUID, bool onlyFavorites = false)
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.SongGetClass.GetSongsInDirectoryAsync",
                    ("directoryUUID", directoryUUID),
                    ("onlyFavorites", onlyFavorites));
            }

            
            public static async Task<List<string>?> GetSongsByNameAsync(string nameFragment, StringComparison comparison = StringComparison.OrdinalIgnoreCase, bool onlyFavorites = false)
            {
                return await EclipseClient.InvokeAsync<List<string>>("Songs.SongGetClass.GetSongsByNameAsync",
                    ("nameFragment", nameFragment),
                    ("comparison", comparison),
                    ("onlyFavorites", onlyFavorites));
            }

            
            public static async Task<List<string>?> GetSongsByTag(SongSearchField field, string value, StringComparison comparison = StringComparison.OrdinalIgnoreCase, bool onlyFavorites = false)
            {
                return await EclipseClient.InvokeAsync<List<string>>("Songs.SongGetClass.GetSongsByTag",
                    ("field", field),
                    ("value", value),
                    ("comparison", comparison),
                    ("onlyFavorites", onlyFavorites));
            }
        }

        public class MusicHistoryClass
        {
            
            public static async Task<DiracResponse?> AddToPlayHistory(string audioFileName, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.MusicHistoryClass.AddToPlayHistory",
                    ("audioFileName", audioFileName),
                    ("directoryUUID", directoryUUID));
            }

            
            public static async Task<DiracPackage?> GetPlayHistory()
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.MusicHistoryClass.GetPlayHistory");
            }

            
            public static async Task<DiracResponse?> ClearPlayHIstory(string audioFileName, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.MusicHistoryClass.ClearPlayHistory",
                    ("audioFileName", audioFileName),
                    ("directoryUUID", directoryUUID));
            }
        }

        public class Playlists
        {
            
            public static async Task<string?> CreatePlaylist(DiracPackage newPlaylist)
            {
                return await EclipseClient.InvokeAsync<string>("Songs.Playlists.CreatePlaylist",
                    ("newPlaylist", newPlaylist));
            }

            
            public static async Task<DiracPackage?> GetAllPlaylists()
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.Playlists.GetAllPlaylists");
            }

            
            public static async Task<DiracPackage?> GetPlaylist(string playlistId)
            {
                return await EclipseClient.InvokeAsync<DiracPackage>("Songs.Playlists.GetPlaylist",
                    ("playlistId", playlistId));
            }

            
            public static async Task<DiracResponse?> UpdatePlaylist(DiracPackage updatedPlaylist)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.Playlists.UpdatePlaylist",
                    ("updatedPlaylist", updatedPlaylist));
            }

            
            public static async Task<DiracResponse?> DeletePlaylist(string playlistId)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.Playlists.DeletePlaylist",
                    ("playlistId", playlistId));
            }

            
            public static async Task<DiracResponse?> AddSongToPlaylist(string playlistId, string songFileName, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.Playlists.AddSongToPlaylist",
                    ("playlistId", playlistId),
                    ("songFileName", songFileName),
                    ("directoryUUID", directoryUUID));
            }

            
            public static async Task<DiracResponse?> RemoveSongFromPlaylist(string playlistId, string songFileName, string directoryUUID)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.Playlists.RemoveSongFromPlaylist",
                    ("playlistId", playlistId),
                    ("songFileName", songFileName),
                    ("directoryUUID", directoryUUID));
            }

            
            public static async Task<DiracResponse?> ReorderPlaylist(string playlistId, List<string> songOrder)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.Playlists.ReorderPlaylist",
                    ("playlistId", playlistId),
                    ("songOrder", songOrder));
            }

            
            public static async Task<DiracResponse?> ToggleFavorite(string playlistId)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("Songs.Playlists.ToggleFavorite",
                    ("playlistId", playlistId));
            }

            
            public static async Task<List<string>?> GetResolvedPlaylistSongs(string playlistId)
            {
                return await EclipseClient.InvokeAsync<List<string>>("Songs.Playlists.GetResolvedPlaylistSongs",
                    ("playlistId", playlistId));
            }

            
            public static async Task<string?> CreatePlaylistFromFolder(string playlistName, string directoryUUID, string? description = null)
            {
                return await EclipseClient.InvokeAsync<string>("Songs.Playlists.CreatePlaylistFromFolder",
                    ("playlistName", playlistName),
                    ("directoryUUID", directoryUUID),
                    ("description", description));
            }

            
            public static async Task<string?> CreatePlaylistFromFavorites(string playlistName)
            {
                return await EclipseClient.InvokeAsync<string>("Songs.Playlists.CreatePlaylistFromFavorites",
                    ("playlistName", playlistName));
            }
        }
    }
}
