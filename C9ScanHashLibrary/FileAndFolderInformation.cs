using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9ScanHashLibrary
{
    public class FileAndFolderInformation
    {
        // List of all files that were found...
        private List<string> myFiles = new List<string>();

        // List of all folders that were found...
        private List<string> myFolders = new List<string>();

        // Working list of folders that we still need to scan...
        private List<string> workingFolders = new List<string>();

        public FileAndFolderInformation(string inPath)
        {
            workingFolders.Add(inPath);

            while (workingFolders.Count() > 0)
            {
                string[] files = System.IO.Directory.GetFiles(workingFolders[0]);
                foreach (string item in files)
                {
                    myFiles.Add(item);
                }

                string[] folders = System.IO.Directory.GetDirectories(workingFolders[0]);
                foreach (string item in folders)
                {
                    myFolders.Add(item);
                    workingFolders.Add(item);
                }
                workingFolders.RemoveAt(0);
            }
        }
    }
}
