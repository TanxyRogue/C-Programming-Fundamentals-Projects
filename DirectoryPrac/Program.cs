using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace DirectoryPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../Unam");
            Directory.Exists("../../Unam");

            Directory.CreateDirectory("../../Unam/Computer Science");
            Directory.CreateDirectory("../../Unam/Information Technology");
            
            string[] directoryLists = Directory.GetDirectories("../../Unam");

            foreach (var dir in directoryLists)
                Console.WriteLine(dir);
            

            Directory.Move("../../Unam", "C:/Users/Tanxy 'Effin' Rogue/Desktop/Unam");
        }
    }
}
