using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;

namespace ConsoleAppStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(5);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            Console.WriteLine("Stack Elements are: ");
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
            s.Pop();
            Console.WriteLine("Stack after Pop() operation: ");
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
            s.Push(4);
            s.Push(5);
            if (s.Count > 5)
            {
                throw new StackOverflowException("cannot push more items stack overflowed");
            }
            else if (s.Count < 1)
            {
                throw new Exception("cannot pop more items stack is underflow");
            }
            //Stack s = new Stack();
            ////s.Push(1);
            ////s.Push(2);
            ////s.Push(3);
            ////s.Push(4);
            ////s.Push(5);
            ////s.Push(6);
            //Console.WriteLine("Stack Elements are: ");
            //foreach (int i in s)
            //{
            //    Console.WriteLine(i);
            //}
            //s.Pop();
            ////s.Pop();
            //Console.WriteLine("Stack after Pop() operation: ");
            //foreach (int i in s)
            //{
            //    Console.WriteLine(i);
            //}

            //if (s.Count > 5)
            //{
            //    throw new StackOverflowException("cannot push more items stack is overflowed");
            //}
            //else if(s.Count < 1)
            //{
            //    throw new Exception("cannot pop more items stack is underflow");
            //}
        }
    }
}
//    var stack = new Stack<int>();

            //    try
            //    {
            //        // This throws an exception.
            //        int pop = stack.Pop();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("unable to pop");
            //        Console.WriteLine(ex.ToString());
            //    }

            //    // Here we safely Pop the stack.
            //    if (stack.Count > 0)
            //    {
            //        int safe = stack.Pop();
            //    }
            //    else
            //    {
            //        Console.WriteLine("underflow");
            //    }
            //}
        //}
        //    Stack st = new Stack(5);
    //    st.Push(1);
    //    st.Push(2);
    //    st.Push(3);
    //    st.Push(4);
    //    st.Push(5);

    //    st.Pop();

    //    foreach (Object obj in st)
    //    {
    //        Console.WriteLine(obj);
    //    }
    //    if (Stack > 5)
    //    {
    //        throw new StackOverflowException("stack is overflow");
    //    }
    //    Console.ReadKey();
    //}

    //public static int Stack { get; set; }



