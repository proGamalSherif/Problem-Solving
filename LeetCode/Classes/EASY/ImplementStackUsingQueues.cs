using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class MyStack
    {
        private Queue<int> queue1;
        private Queue<int> queue2;
        public MyStack()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }
        public void Push(int x)
        {
            queue2.Enqueue(x);
            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            var temp = queue1;
            queue1 = queue2;
            queue2 = temp;

        }

        public int Pop()
        {
            return queue1.Dequeue();
        }

        public  int Top()
        {
            return queue1.Peek();
        }

        public bool Empty()
        {
            return queue1.Count == 0;
        }
        public static void Run()
        {
            MyStack myS = new MyStack();
            myS.Push(501);
            myS.Push(205);
            Console.WriteLine(myS.Top());
            Console.WriteLine(myS.Pop());
            Console.WriteLine(myS.Empty());
        }
    }
}
