using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileFiltrerCSharp
{
    public class FileMover
    {
        public void MoveFile(List<string> types, string sourcePath, string targetPath)
        {
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            foreach (string fileType in types)
            {
                string[] sourcefiles = Directory.GetFiles(sourcePath, "*." + fileType);

                foreach (string sourcefile in sourcefiles)
                {
                    string fileName = Path.GetFileName(sourcefile);
                    string destFile = Path.Combine(targetPath, fileName);
                    Console.WriteLine("Déplacement de '" + fileName + "' dans '" + targetPath );

<<<<<<< HEAD
                    if (!Directory.Exists(targetPath))
                    {
                        File.Move(sourcefile, destFile);
                    }
=======
                    File.Move(sourcefile, destFile);
>>>>>>> FileFilter
                }
            }
        }
    }
}
