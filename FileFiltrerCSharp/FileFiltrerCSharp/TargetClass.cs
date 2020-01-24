using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace FileFiltrerCSharp
{
    public class Target
    {
        private string folderName;
        private List<string> types = new List<string>();

        public Target(string folderName, List<string> types)
        {
            this.folderName = folderName;
            this.types = types;
        }

        public string FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        public List<string> Types
        {
            get { return types; }
            set { types = value; }
        }
    }
}
