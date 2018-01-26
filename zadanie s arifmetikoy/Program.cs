using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_s_arifmetikoy
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            //x += y - x++ * z;
            //Console.WriteLine(value: x);
            //z = --x – y * 5;
            //Console.WriteLine(value: z);
            //y /= x + 5 % z;
            //Console.WriteLine(value: y);
            //z = x++ + y * 5;
            //Console.WriteLine(value: z);
            x = y - x++ * z;
            Console.WriteLine(value: x);
            Console.ReadLine();
        }
    }
}
