namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader input = new StreamReader(inputFilePath))
            {
                string line = input.ReadLine();
                int count = 1;
                using (StreamWriter output = new StreamWriter(outputFilePath))
                {
                    try
                    {
                        while (input.EndOfStream == false)
                        {
                            output.WriteLine($"{count}. {line}");
                            line = input.ReadLine();
                            count++;
                            output.WriteLine($"{count}. {line}");
                        }

                    }
                    catch (System.Exception)
                    {

                        throw;
                    }
                    finally 
                    {
                    input.Close();
                    input.Dispose();
                    }
                }
            }
        }
    }
}
