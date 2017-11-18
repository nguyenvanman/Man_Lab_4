using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_7
{
    class Program
    {
        static void Swap<T>(ref T item1, ref T item2)
        {
            T temp;
            temp = item1;
            item1 = item2;
            item2 = temp;
        }
        static void Sort<T>(T[] list) where T : ICompare
        {
            for (var i = 0; i < list.Length - 1; i++)
            {
                for (var j = i + 1; j < list.Length; j++)
                {
                    if ((list[i]).IsBigger(list[j]))
                    {
                        Swap(ref list[i],ref list[j]);
                    }
                }
            }
        }
        static void ShowList<T>(T[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private static void Main(string[] args)
        {
            var student1 = new Student("Student 1", new DateTime(2017, 10, 11), 31);
            var student2 = new Student("Student 2", new DateTime(2017, 10, 11), 52);
            var student3 = new Student("Student 3", new DateTime(2017, 10, 11), 23);
            var student4 = new Student("Student 4", new DateTime(2017, 10, 11), 47);
            var student5 = new Student("Student 5", new DateTime(2017, 10, 11), 62);
            var listStudents = new [] {student1, student2, student3, student4, student5};
            Sort(listStudents);
            ShowList(listStudents);
            
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(12, 5, 13);
            var triangle3 = new Triangle(6, 8, 10);
            var triangle4 = new Triangle(3, 5, 5);
            var triangle5 = new Triangle(3, 4, 6);
            var listTriangles = new [] {triangle1, triangle2, triangle3, triangle4, triangle5};
            Sort(listTriangles);
            ShowList(listTriangles);

            var country1 = new Country("Country 1", 124);
            var country2 = new Country("Country 2", 412);
            var country3 = new Country("Country 3", 1256);
            var country4 = new Country("Country 4", 321);
            var listCountries = new [] {country1, country2, country3, country4};
            Sort(listCountries);
            ShowList(listCountries);

            Console.ReadKey();
        }
    }
}
