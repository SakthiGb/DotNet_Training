using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=Class1.add(13, 20);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
