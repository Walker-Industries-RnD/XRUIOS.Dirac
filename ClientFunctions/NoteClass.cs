using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ClientFunctions
{
    public class NoteClass
    {
        
        public static async Task<DiracResponse?> SaveJournal(DiracPackage journal)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NoteClass.SaveJournal",
                ("journal", journal));
        }

        
        public static async Task<DiracPackage?> GetAllJournals()
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("NoteClass.GetAllJournals");
        }

        
        public static async Task<DiracPackage?> GetJournal(string FileName)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("NoteClass.GetJournal",
                ("FileName", FileName));
        }

        
        public static async Task<DiracPackage?> GetCategory(string JournalName, string CategoryName)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("NoteClass.GetCategory",
                ("JournalName", JournalName),
                ("CategoryName", CategoryName));
        }

        
        public static async Task<string?> UpdateJournal(DiracPackage journal, DiracPackage newJournal)
        {
            return await EclipseClient.InvokeAsync<string>("NoteClass.UpdateJournal",
                ("journal", journal),
                ("newJournal", newJournal));
        }

        
        public static async Task<DiracResponse?> DeleteJournal(string fileName)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NoteClass.DeleteJournal",
                ("fileName", fileName));
        }

        
        public static async Task<DiracResponse?> AddJournalToFavorites(string journalId)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NoteClass.AddJournalToFavorites",
                ("journalId", journalId));
        }

        
        public static async Task<ValueTuple<List<string>, List<string>>> GetJournalFavorites()
        {
            return await EclipseClient.InvokeAsync<ValueTuple<List<string>, List<string>>>("NoteClass.GetJournalFavorites");
        }

        
        public static async Task<List<string>?> GetFavoriteJournalIdsAsync(bool onlyResolved)
        {
            return await EclipseClient.InvokeAsync<List<string>>("NoteClass.GetFavoriteJournalIdsAsync",
                ("onlyResolved", onlyResolved));
        }

        
        public static async Task<DiracResponse?> RemoveJournalFromFavorites(string JournalId)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NoteClass.RemoveJournalFromFavorites",
                ("JournalId", JournalId));
        }

        
        public static async Task<DiracResponse?> AddHistoryEntry(string TargetType, string Action, string TargetID, Dictionary<string, string>? Meta)
        {
            return await EclipseClient.InvokeAsync<DiracResponse>("NoteClass.AddHistoryEntry",
                ("TargetType", TargetType),
                ("Action", Action),
                ("TargetID", TargetID),
                ("Meta", Meta));
        }

        
        public static async Task<DiracPackage?> GetHistory(string TargetType, string? TargetID)
        {
            return await EclipseClient.InvokeAsync<DiracPackage>("NoteClass.GetHistory",
                ("TargetType", TargetType),
                ("TargetID", TargetID));
        }
    }
}
