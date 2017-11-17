using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Swap<T> (ref T value1, ref T value2)
        {
            T temp;
            temp = value1;
            value1 = value2;
            value2 = temp;
        }
        static void Main(string[] args)
        {
            var value1 = 10;
            var value2 = 5;
            Swap(ref value1, ref value2);
            Console.WriteLine("value1 = " + value1);
            Console.WriteLine("value2 = " + value2);
            Console.ReadKey();
        }
    }
}
