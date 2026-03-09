using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    // MediaTagger reuses the CreatorClass RPC endpoints — it has no separate server-side registrations
    // FileRecord (YuukoProtocol): { string UUID, string File }
    internal class MediaTagger
    {
        public class CreatorClass
        {
            public class CreatorFileClass
            {
                public static async Task<DiracResponse?> CreateCreator(string name, string? description, string? pfp, List<string> files, string category)
                    => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.CreateCreator",
                        ("CreatorName", name), ("Description", description), ("PFPPath", pfp),
                        ("FilePaths", files), ("CreatorType", category));

                public static async Task<DiracPackage?> GetCreator(string name, string category)
                    => await EclipseClient.InvokeAsync<DiracPackage>("CreatorClass.CreatorFileClass.GetCreator",
                        ("CreatorName", name), ("CreatorType", category));

                public static async Task<ValueTuple<string, string>?> GetCreatorOverview(string name, string category)
                    => await EclipseClient.InvokeAsync<ValueTuple<string, string>>("CreatorClass.CreatorFileClass.GetCreatorOverview",
                        ("CreatorName", name), ("CreatorType", category));

                public static async Task<List<DiracPackage>?> GetCreatorFiles(string name, string category)
                    => await EclipseClient.InvokeAsync<List<DiracPackage>>("CreatorClass.CreatorFileClass.GetCreatorFiles",
                        ("CreatorName", name), ("CreatorType", category));

                public static async Task<DiracResponse?> AddFile(string name, string category, List<string> files)
                    => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.AddFile",
                        ("CreatorName", name), ("CreatorType", category), ("FilePaths", files));

                public static async Task<DiracResponse?> SetDescription(string name, string category, string description)
                    => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.SetDescription",
                        ("CreatorName", name), ("CreatorType", category), ("Description", description));

                public static async Task<DiracResponse?> RemoveFiles(string name, string category, List<DiracPackage> files)
                    => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.RemoveFiles",
                        ("CreatorName", name), ("CreatorType", category), ("filesToRemove", files));
            }
        }

        public class CreatorFavoritesClass
        {
            public static async Task<DiracResponse?> AddToFavorites(string id, string category)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFavoritesClass.AddToFavorites",
                    ("CreatorName", id), ("CreatorType", category));

            public static async Task<ValueTuple<List<string>, List<string>>?> GetFavorites(string category)
                => await EclipseClient.InvokeAsync<ValueTuple<List<string>, List<string>>>("CreatorClass.CreatorFavoritesClass.GetFavorites",
                    ("CreatorType", category));

            public static async Task<List<string>?> GetFavoritePathsAsync(string category, bool resolveFiles)
                => await EclipseClient.InvokeAsync<List<string>>("CreatorClass.CreatorFavoritesClass.GetFavoritePathsAsync",
                    ("CreatorType", category), ("onlyResolved", resolveFiles));

            public static async Task<DiracResponse?> RemoveFromFavorites(string id, string category)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFavoritesClass.RemoveFromFavorites",
                    ("CreatorName", id), ("CreatorType", category));
        }
    }
}
