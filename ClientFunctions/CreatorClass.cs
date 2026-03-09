using EclipseLCL;
using EclipseProject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class CreatorClass
    {
        // Creator is in XRUIOS.Barebones namespace → XRUIOS type → DiracPackage over the wire
        // FileRecord (YuukoProtocol): { string UUID, string File }

        public class CreatorFileClass
        {
            public static async Task<DiracResponse?> CreateCreator(string CreatorName, string? Description, string? PFPPath, List<string> FilePaths, string CreatorType)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.CreateCreator",
                    ("CreatorName", CreatorName), ("Description", Description), ("PFPPath", PFPPath),
                    ("FilePaths", FilePaths), ("CreatorType", CreatorType));

            public static async Task<DiracPackage?> GetCreator(string CreatorName, string CreatorType)
                => await EclipseClient.InvokeAsync<DiracPackage>("CreatorClass.CreatorFileClass.GetCreator",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType));

            public static async Task<ValueTuple<string, string>?> GetCreatorOverview(string CreatorName, string CreatorType)
                => await EclipseClient.InvokeAsync<ValueTuple<string, string>>("CreatorClass.CreatorFileClass.GetCreatorOverview",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType));

            public static async Task<List<DiracPackage>?> GetCreatorFiles(string CreatorName, string CreatorType)
                => await EclipseClient.InvokeAsync<List<DiracPackage>>("CreatorClass.CreatorFileClass.GetCreatorFiles",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType));

            public static async Task<DiracResponse?> AddFile(string CreatorName, string CreatorType, List<string> FilePaths)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.AddFile",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType), ("FilePaths", FilePaths));

            public static async Task<DiracResponse?> SetDescription(string CreatorName, string CreatorType, string Description)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.SetDescription",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType), ("Description", Description));

            public static async Task<DiracResponse?> RemoveFiles(string CreatorName, string CreatorType, List<DiracPackage> filesToRemove)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFileClass.RemoveFiles",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType), ("filesToRemove", filesToRemove));
        }

        public class CreatorFavoritesClass
        {
            public static async Task<DiracResponse?> AddToFavorites(string CreatorName, string CreatorType)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFavoritesClass.AddToFavorites",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType));

            public static async Task<ValueTuple<List<string>, List<string>>?> GetFavorites(string CreatorType)
                => await EclipseClient.InvokeAsync<ValueTuple<List<string>, List<string>>>("CreatorClass.CreatorFavoritesClass.GetFavorites",
                    ("CreatorType", CreatorType));

            public static async Task<List<string>?> GetFavoritePathsAsync(string CreatorType, bool onlyResolved)
                => await EclipseClient.InvokeAsync<List<string>>("CreatorClass.CreatorFavoritesClass.GetFavoritePathsAsync",
                    ("CreatorType", CreatorType), ("onlyResolved", onlyResolved));

            public static async Task<DiracResponse?> RemoveFromFavorites(string CreatorName, string CreatorType)
                => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.CreatorFavoritesClass.RemoveFromFavorites",
                    ("CreatorName", CreatorName), ("CreatorType", CreatorType));
        }

        public static async Task<DiracResponse?> InitiateCreatorClass(string CreatorType)
            => await EclipseClient.InvokeAsync<DiracResponse>("CreatorClass.InitiateCreatorClass", ("CreatorType", CreatorType));
    }
}
