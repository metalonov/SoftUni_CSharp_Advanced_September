namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long CalculateFolderSize(string folderPath)
            {

                string[] files = Directory.GetFiles(folderPath);
                long bytes = 0;
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo info = new FileInfo(files[i]);

                    Console.WriteLine($"{info.Name} - {info.Length} bytes");
                    bytes += info.Length;
                }

                string[] directories = Directory.GetDirectories(folderPath);
                foreach (var directoryPath in directories)
                {
                    bytes += CalculateFolderSize(directoryPath);
                }

                return bytes;
            }

        }
    }
}
