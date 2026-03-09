using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClientFunctions;
using EclipseProject;

namespace XRUIOS.Dirac
{
    public class Class1
    {
        public static async Task Main(string[] args)
        {
        string creatorType = "Music";

        // Grab a random file from the Music folder
        string musicFolder = System.Environment.SpecialFolder.MyMusic.ToString();
        List<string> filePaths = new List<string>();

        if (Directory.Exists(musicFolder))
        {
            var allFiles = Directory.GetFiles(musicFolder).ToList();
            if (allFiles.Count > 0)
            {
                var rand = new Random();
                filePaths.Add(allFiles[rand.Next(allFiles.Count)]);
            }
        }

        // Step 1: Create a new creator with at least one file
        await CreatorClass.CreatorFileClass.CreateCreator("YUNA2", "Second best virtual idol", null, filePaths, creatorType);

        
        }
    }
}
