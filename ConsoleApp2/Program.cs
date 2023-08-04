using System;
using System.IO;

class Program
{
    static void Main()
    {

        string filePath = "hello.txt";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("The file does not exist.");
            return;
        }

        // Read all lines from the file
        string[] lines;
        using (StreamReader reader = new StreamReader(filePath))
        {
            // Count the number of lines in the file
            int lineCount = 0;
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }

            // Initialize the array to hold the lines
            lines = new string[lineCount];
        }

        // Read the file again and store each line in the array
        using (StreamReader reader = new StreamReader(filePath))
        {
            int i = 0;
            while (!reader.EndOfStream)
            {
                lines[i++] = reader.ReadLine();
            }
        }



        foreach (string line in lines)
        {
            Console.WriteLine(line);

        }

        Console.ReadKey();
        Main();
    }
}

