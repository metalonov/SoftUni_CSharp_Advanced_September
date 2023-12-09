namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            FileStream input1 = new FileStream(binaryFilePath, FileMode.Open);
            FileStream input2 = new FileStream(bytesFilePath, FileMode.Open);
            FileStream outputFile = new FileStream(outputPath, FileMode.OpenOrCreate);
            byte[] data = new byte[input1.Length];
            byte[] dataCompare = new byte[input2.Length];
            input1.Read(data, 0, bytesFilePath.Length);
            for (int i = 0; i < dataCompare.Length; i++)
            {
                for (int k = 0; k < data.Length; k++)
                {
                    if (data[k] == dataCompare[i])
                    {
                        Console.WriteLine(data[i]);
                    }
                }
            }
        }
    }
}