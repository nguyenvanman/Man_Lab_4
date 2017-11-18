using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenegicApplication
{
    public class Queue<T>
    {
        private T[] items;
        private int rear;
        private int front;
        private int size;
        private int itemCount;

        public Queue(int size)
        {
            this.size = size;
            items = new T[size];
            front = 0;
            rear = -1;
            itemCount = 0;
        }

        public bool IsEmpty()
        {
            return itemCount == 0;
        }

        public bool IsFull()
        {
            return itemCount == size;
        }

        public int Size()
        {
            return itemCount;
        }

        public void EnQueue(T item)
        {
            if (!IsFull())
            {
                if (rear == size - 1)
                {
                    rear = -1;
                }
                items[++rear] = item;
                itemCount++;
            }
        }

        public T DeQueue()
        {
            T item = items[front++];
            if (front == size)
            {
                front = 0;
            }
            itemCount--;
            return item;
        }
    }

}
namespace Exercise_5
{
    using GenegicApplication;
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(10);
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());
            queue.EnQueue("qwheoqa");
            queue.EnQueue("qwewqe12");
            queue.EnQueue("iuqwhaskjd");
            Console.WriteLine("Size: " + queue.Size());
            Console.WriteLine(queue.DeQueue());
            Console.ReadKey();
        }
    }
}
