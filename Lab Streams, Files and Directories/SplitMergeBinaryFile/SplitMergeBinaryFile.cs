namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream inputFile = new FileStream(sourceFilePath, FileMode.Open))
            {
                byte[] inputArr = File.ReadAllBytes(sourceFilePath);
                    using (FileStream partOne = new FileStream(partOneFilePath, FileMode.Open))
                    {
                    for (int i = 0; i < inputArr.Length / 2; i++)
                        {
                        partOne.Write(inputArr, i, inputArr.Length / 2);
                        }
                    }
                    using (FileStream partTwo = new FileStream(partTwoFilePath, FileMode.Open))
                    {
                        for (int i = 0; i < inputFile.Length / 2; i++)
                        {

                        }
                    }
            }

        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
        }
    }
}