using System;
using System.IO;
using System.Collections.Generic;

namespace FileFiltrerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Target> targetList = new List<Target>();
            targetList.Add(new Target("EXEs", new List<string>() { "ps1", "bat", "exe", "jar", "msi" }));
            targetList.Add(new Target("DOCs", new List<string>() { "txt", "pdf", "rtf", "odt", "txt", "docx", "doc", "html", "htm" }));
            targetList.Add(new Target("MEDIAs", new List<string>() { "wav", "avi", "mkv", "mp3", "mp4" }));
            targetList.Add(new Target("PICTUREs", new List<string>() { "png", "gif", "ico", "mpg", "mpe", "mpeg", "jpe", "jpg", "jpeg", "jfif" }));
<<<<<<< HEAD
            targetList.Add(new Target("ARCHIVEs", new List<string>() { "xml", "pps", "xls", "xlsx"}));
=======
            targetList.Add(new Target("ARCHIVEs", new List<string>() { "xml", "pps", "xls", "xlsx" }));
>>>>>>> FileFilter
            targetList.Add(new Target("ZIPs", new List<string>() { "zip", "rar", "torrent" }));
            Console.WriteLine("Ajout des folders.");

            FileMover fileMover = new FileMover();
<<<<<<< HEAD

            foreach(Target target in targetList)
            {
                string sourcePath = @"Y:\Téléchargements\";
=======
            
            foreach(Target target in targetList)
            {
                string sourcePath = @"C:\Users\Afryk\Downloads\";
>>>>>>> FileFilter

                if (!Directory.Exists(sourcePath + target.FolderName)){
                    Directory.CreateDirectory(sourcePath + target.FolderName);
                    Console.WriteLine("Création du folder '" + target.FolderName + "'.");
                }
<<<<<<< HEAD
                string targetPath = sourcePath + target.FolderName;
=======
                string targetPath = @"C:\Users\Afryk\Downloads\" + target.FolderName;
>>>>>>> FileFilter

                fileMover.MoveFile(target.Types, sourcePath, targetPath);
            }
        }
    }
}
