using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_file2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\NumbersSum.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-20, 20));
                }
            }
            int [] array = new int[10];
            int Sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                  array[i] = Convert.ToInt32(sr.ReadLine());
                  Sum += array[i];
                }
            }
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}
