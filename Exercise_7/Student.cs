using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    public class Student : ICompare
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public double Score { get; set; }

        public Student(string name, DateTime birthday, double score)
        {
            Name = name;
            Birthday = birthday;
            Score = score;
        }

        bool ICompare.IsBigger(ICompare another)
        {
            return Score > ((Student) another).Score;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tBirthday: {Birthday.ToString("yyyy-M-d dddd")}\tScore: {Score}";


        }
    }
}
