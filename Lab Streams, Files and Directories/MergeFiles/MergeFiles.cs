namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader input1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader input2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter outputFile = new StreamWriter(outputFilePath, true))
                    {
                        while (input2.EndOfStream == false)
                        {
                            string lineFromInput1 = input1.ReadLine();
                            string lineFromInput2 = input2.ReadLine();
                            outputFile.WriteLine(lineFromInput1);
                            outputFile.WriteLine(lineFromInput2);
                        }
                    }
                }
            }
        }
    }
}
