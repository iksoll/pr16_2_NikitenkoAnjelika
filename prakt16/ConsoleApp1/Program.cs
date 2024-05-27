using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 5.1, 1.3, 9.2, 2.3, 5.1, 3 };
            Dictionary<double, int> frequencies = new Dictionary<double, int>();
            foreach (double num in a)
                    {
                if (frequencies.ContainsKey(num))
                {
                    frequencies[num]++;
                }
                else
                {
                    frequencies[num] = 1;
                }
            }
            Console.WriteLine("Старый массив");
            foreach (var pair in frequencies)
            {
                Console.WriteLine("Число: " + pair.Key);
                Console.WriteLine("Частота: " + pair.Value);
                Console.WriteLine();
                for (int i=0;i<a.Length; i++)
                {
                    if (a[i] == pair.Key)
                    {
                        a[i] = a[i] * pair.Value;
                    }
                }
            }
            Console.WriteLine("Новый массив");
            foreach (double num in a)
            {
                Console.WriteLine(num);
            }
        }
    }
}
