using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExtensions
{
    public static class StringExtension
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] {' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
namespace Exercise_1
{
    using CustomExtensions;
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Extension method exercise";
            Console.WriteLine("Word count of str: " + str.WordCount());
            Console.ReadKey();
        }
    }
}
