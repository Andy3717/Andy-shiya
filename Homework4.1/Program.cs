using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            head = null;
            tail = null;
        }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> n = head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, max = int.MinValue, min = int.MaxValue;
            GenericList<int> intlist = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }
            intlist.ForEach(m => sum += m);
            Console.WriteLine("sum:" + sum);
            intlist.ForEach((m) => max = m > max ? m : max);
            Console.WriteLine("max:" + max);
            intlist.ForEach(m => min = m < min ? m : min);
            Console.WriteLine("min:" + min);
            Console.ReadKey();
        }
    }
}

