using EclipseProject;
using EclipseLCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFunctions
{
    public class ClipboardClass
    {
        public class BaseClipboard
        {
            
            public async Task<Dictionary<string, byte[]>?> LoadClipboard()
            {
                return await EclipseClient.InvokeAsync<Dictionary<string, byte[]>>("ClipboardClass.BaseClipboard.LoadClipboard");
            }

            
            public async Task<byte[]?> GetClipboardItem(string key)
            {
                return await EclipseClient.InvokeAsync<byte[]>("ClipboardClass.BaseClipboard.GetClipboardItem",
                    ("key", key));
            }

            
            public async Task<DiracResponse?> AddToClipboard(byte[] item, string key)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("ClipboardClass.BaseClipboard.AddToClipboard",
                    ("item", item),
                    ("key", key));
            }

            
            public async Task<DiracResponse?> RemoveFromClipboard(string key)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("ClipboardClass.BaseClipboard.RemoveFromClipboard",
                    ("key", key));
            }
        }

        public class ClipboardGroups
        {
            
            public async Task<Dictionary<string, byte[]>?> LoadClipboard(string groupName)
            {
                return await EclipseClient.InvokeAsync<Dictionary<string, byte[]>>("ClipboardClass.ClipboardGroups.LoadClipboard",
                    ("groupName", groupName));
            }

            
            public async Task<byte[]?> GetClipboardItem(string groupName, string key)
            {
                return await EclipseClient.InvokeAsync<byte[]>("ClipboardClass.ClipboardGroups.GetClipboardItem",
                    ("groupName", groupName),
                    ("key", key));
            }

            
            public async Task<DiracResponse?> AddToClipboard(string groupName, byte[] item, string key)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("ClipboardClass.ClipboardGroups.AddToClipboard",
                    ("groupName", groupName),
                    ("item", item),
                    ("key", key));
            }

            
            public async Task<DiracResponse?> RemoveFromClipboard(string groupName, string key)
            {
                return await EclipseClient.InvokeAsync<DiracResponse>("ClipboardClass.ClipboardGroups.RemoveFromClipboard",
                    ("groupName", groupName),
                    ("key", key));
            }
        }
    }
}
