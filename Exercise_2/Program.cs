using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExtensions
{
    public static class StringExtension
    {
        public static string CaptionFirst(this String str)
        {
            return str[0].ToString().ToUpper() + str.Substring(1).ToLower();
        }
    }
}
namespace Exercise_2
{
    using CustomExtensions;
    class Program
    {
        static void Main(string[] args)
        {
            string str = "heLlO";
            Console.WriteLine(str.CaptionFirst());
            Console.ReadKey();
        }
    }
}
