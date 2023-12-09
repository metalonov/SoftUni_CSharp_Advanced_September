namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);

        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            int counter = 0;
            while (reader.EndOfStream == false)
            {

                string line = reader.ReadLine();
                if (counter++ % 2 == 1)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}


