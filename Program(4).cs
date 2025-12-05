using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication137
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, sum, s;
            s = 0;
            sum = 0;
            a = float.Parse(Console.ReadLine());
            float max, min;
            max = a;
            min = a;
            sum = sum + a;
            for (int i = 1; i <= 14; i++)
            {
                s = float.Parse(Console.ReadLine());
                if (s < min)
                    min = s;
                if (s > max)
                    max = s;
                sum += s;
                continue;
            }
            Console.WriteLine("min" + min);
            Console.WriteLine("max" + max);
            float e = max - min;
            Console.WriteLine("e" + e);
            Console.WriteLine("sum" + sum);
            float avg = sum / 15;
            Console.WriteLine("avg" + avg);

            Console.ReadKey();
        }
    }
}
