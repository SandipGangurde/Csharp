using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileReaderWriter
    {
        public void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine("File read successfully.");
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }

        public void AppendTextToFile(string filePath, string textToAppend)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.Write(textToAppend);
                }
                Console.WriteLine("Text appended to the file.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while appending to the file: {e.Message}");
            }
        }

        public void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully.");
            }
            else
            {
                Console.WriteLine("The file does not exist, so it cannot be deleted.");
            }
        }
    }
}
