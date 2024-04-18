using System;

namespace PracticeConsole
{
     abstract class Person()
    {
        public abstract void Display();
        public virtual void Show()   // property
        {
            Console.WriteLine("Smiley");
        }
    }
    class Person2 : Person
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }
        public override void Show()
        {
            Console.WriteLine("Jency");
        }
    }

    internal interface IYoutube
    {
        void Demo();
    }
    interface IGmail
    {
        void Send();
    }

    class Google:IGmail, IYoutube
    {
        public void Send(){ Console.WriteLine("Mail send"); }
        public void Demo() { Console.WriteLine("Watch video"); }
    }

    enum Enum
    {
        spiderman=30,
        superman=100,
        batman=50
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person2();
            p.Show();
            Google google = new();
            google.Demo();
            google.Send();
            int @enum =(int)Enum.batman;
            Console.WriteLine(@enum);
            int[] a = [1, 2, 3, 0, 5];

            try
            {
                Console.WriteLine(a[5]);
                throw new Exception("Index out of bound dude!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            int divisor = 0;
            if (divisor== 0)
            {
                // Throw a new instance of DivideByZeroException
                throw new Exception("Divisor is equal to zero.");
            }
        }
    }
}

