using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExtensions
{
    public static class IntergerExtension
    {
        public static bool IsPrime(this int number)
        {
            if (number < 2) return false;
            for (int i = (int) Math.Sqrt(number); i >= 2; i--)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
namespace Exercise_3
{
    using CustomExtensions;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2.IsPrime());
            Console.WriteLine(0.IsPrime());
            Console.WriteLine(6.IsPrime());
            Console.WriteLine(3213.IsPrime());
            Console.ReadKey();
        }
    }
}
