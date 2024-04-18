using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine(t.Name);

            //C# Threading Example: static method
            MyThread obj = new MyThread();
            Thread t1 = new Thread(new ThreadStart(obj.Thread1));
            Thread t2 = new Thread(new ThreadStart(obj.Thread1));
            Thread t5 = new Thread(new ThreadStart(obj.Thread1));
            t1.Name = "smiley";
            t2.Name = "Jack";
            t5.Name = "rose";

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t5.Priority = ThreadPriority.Normal;

            Thread t3 = new Thread(new ThreadStart(MyThread1.Task1));
            Thread t4 = new Thread(new ThreadStart(MyThread1.Task2));

           
            t1.Start();
            t1.Join();
            t2.Start();
            t5.Start();

            //t3.Start();
            //t4.Start();


            Console.ReadLine();
        }
    }
    public class MyThread1
    {
        public static void Task1()
        {
            Console.WriteLine("Task1");
        }
        public static void Task2()
        {
            Console.WriteLine("Task2");
        }
    }

    public class MyThread
    {
        public  void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
        }
    }
}
