using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPracticeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\nagar\Desktop\Student Data.txt";

            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please make sure the file exists at the specified path.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadKey();

        }
    }
}
