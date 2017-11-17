using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    public class Stack<T>
    {
        private T[] items;
        private int top;
        private int size;
        public Stack(int size)
        {
            this.size = size;
            items = new T[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == size - 1;
        }

        public void Push(T item)
        {
            if (!IsFull())
            {
                items[++top] = item;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public T Pop()
        {
            var item = items[top--];
            return item;
        }
    }

}
namespace Exercise_6
{
    using GenericApplication;
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(5);
            Console.WriteLine(stack.IsEmpty());
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.IsFull());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadKey();
        }
    }
}
