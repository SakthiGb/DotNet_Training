using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_IO
{
    class Program
    {
        static void Main(string[] args)
        {
        //FileStream f = new FileStream("D:\\Basic.txt", FileMode.Create);
        //StreamWriter s = new StreamWriter(f);

        //s.WriteLine("Hello Team\n Have a Good day :)😁😁😁");
        //s.Close();
        //f.Close();
        //Console.WriteLine("File created successfully...");

        ////C# StreamReader
        //FileStream f = new FileStream("D:\\Basic.txt", FileMode.OpenOrCreate);
        //StreamReader s = new StreamReader(f);

        //string line = s.ReadLine();
        //Console.WriteLine(line);

        //s.Close();
        //f.Close();

        //Console.ReadLine();
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Enter Input: ");
            string input = Console.ReadLine();
            string input2="";
            foreach (string i in cars)
            {
                if (i == input)
                {
                    Console.WriteLine(i);
                    input2=input;
                    break;
                }
            }
            if (input2 == "") {
                Console.WriteLine("No match");
            }
            Console.ReadLine();
        }
    }
}
