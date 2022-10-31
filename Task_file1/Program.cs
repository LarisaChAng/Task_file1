using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_file1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
