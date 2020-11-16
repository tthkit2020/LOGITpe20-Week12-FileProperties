using System;
using System.Collections.Generic;
using System.IO;

namespace FilesAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //to get the file names only
            string rootPath = @"C:\Users\julia.voronetskaja\samples";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach(string file in files)
            {
                //get file objects
                var fileData = new FileInfo(file);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                Console.WriteLine($"File name: {fileName}; location: {fileDirectory}; Size: {fileSize} ");
                string line = $"File name: {fileName}; location: {fileDirectory}; Size: {fileSize} bytes";
                lines.Add(line);
            }

            string fileDataPath = @"C:\Users\julia.voronetskaja\samples\fileData.txt";
            File.WriteAllLines(fileDataPath, lines);
        }
    }
}
