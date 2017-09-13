using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using C9ScanHashLibrary;

namespace C9ScanHashTest
{
    [TestFixture]
    public class FilesAndFoldersTest
    {
        [Test]
        public void getFoldersTest()
        {
            FileAndFolderInformation information = new FileAndFolderInformation ("c:\\temp");
        }
    }
}
