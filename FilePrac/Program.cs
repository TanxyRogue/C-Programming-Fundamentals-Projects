using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePrac
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fileWriteStream = new FileStream("../../Resources/Lecturer.txt", FileMode.Create, FileAccess.ReadWrite);

            if (File.Exists("../../Resources/Lecturer.txt"))
            {
                //Displaying File Info
                Console.WriteLine("File exists");
                Console.WriteLine("File was created: " + File.GetCreationTime("../../Resources/Lecturer.txt"));
                Console.WriteLine("File was last written: " + File.GetLastWriteTime("../../Resources/Lecturer.txt"));
                Console.WriteLine();

                // To the file
                StreamWriter writer = new StreamWriter(fileWriteStream);
                writer.WriteLine("Some text for the file");
                writer.Dispose();
                fileWriteStream.Dispose();

                //Reading File Contents
                FileStream fileReadStream = new FileStream("../../Resources/Lecturer.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileReadStream);
                string readText = reader.ReadLine();
                Console.WriteLine($"File Contains Following Text: \n {readText}");
                reader.Dispose();
                fileReadStream.Dispose();
            }
        }
    }
}
