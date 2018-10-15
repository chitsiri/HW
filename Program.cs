using System;
using System.Collections;

namespace Homework
{
    class implementStack
    {
        public object[] number;
        public int top;
        public int size;
        public int max;

        public void Stack(int size)
        {
            number = new object[size];
            max = size;
            top = -1; //
        }
        void Push(object item)
        {
            if (top == max - 1) //เซ็คข้อมูลที่เข้าว่ามีพท ว่างมั้ย
            {
                Console.WriteLine("Invalid");
                return;
            }
            else
                number[++top] = item;
            return;
        }
        object Pop()
        {

            if (top == -1)
            {
                throw new InvalidOperationException("stack is empty");
            }
            else

                return number[top--];
        }
        void Clear()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine("{0}", number[i]);
            }
            Console.WriteLine();
        }
        public void Print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                    Console.WriteLine("{0}", number[i]);
            }
        }
    }

}

class Program
{

    static void Main(string[] args)
    {
        var s = new Stack();
        s.Push(1);
        s.Push(2);
        s.Push(3);

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());



    }
}
