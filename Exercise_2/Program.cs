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
            if (str.Length == 0) return str;
            string captionFirstString = str[0].ToString().ToUpper();
            for (int i = 1; i < str.Length; i++)
            {
                captionFirstString += str[i].ToString().ToLower();
            }
            return captionFirstString;
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
