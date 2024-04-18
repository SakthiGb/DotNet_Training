using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Madurai To New Delhi ********");
            Console.Write("Enter No of Tickets: ");
            int count=int.Parse(Console.ReadLine());
            var middleStation = 1;
            string[] station = { "1.Tamil Nadu", "2.Bengaluru", "3.Telangana", "4.Nagpore", "5.New Delhi"};

            Console.WriteLine("Select Starting Point: ");
            for (int i = 0; i <= station.Length - 1; i++)
            {
                Console.WriteLine(station[i]);
            }
            int startingPoint = int.Parse(Console.ReadLine());
            Console.WriteLine("Selected Start Point: "+ station[startingPoint-1]);

            Console.WriteLine("Select Destination: ");
            for (int i = 0; i <= station.Length - 1; i++)
            {
                Console.WriteLine(station[i]);
            }
            int destination = int.Parse(Console.ReadLine());
            Console.WriteLine("Selected destination: " + station[destination-1]);

            for(int i= startingPoint+1; i<= station.Length; i++)
            {
                if(i== destination) break;
                middleStation++;
            }
            Console.WriteLine();

            switch (middleStation)
            {
                case 1:
                    Console.WriteLine(station[startingPoint-1]);
                    Console.WriteLine(station[destination-1]);
                    Console.WriteLine($"Ticket Fare : {count} * 100 = {count*100}");
                    Console.WriteLine("Time to Reach: 10hours");
                    break;
                case 2:
                    Console.WriteLine(station[startingPoint - 1]);
                    Console.WriteLine(station[destination - 1]);
                    Console.WriteLine($"Ticket Fare : {count} * 200 = {count * 200}");
                    Console.WriteLine("Time to Reach: 20hours");
                    break;
                case 3:
                    Console.WriteLine(station[startingPoint - 1]);
                    Console.WriteLine(station[destination - 1]);
                    Console.WriteLine($"Ticket Fare : {count} * 300 = {count * 300}");
                    Console.WriteLine("Time to Reach: 1 day 6 hours");
                    break;
                case 4:
                    Console.WriteLine(station[startingPoint - 1]);
                    Console.WriteLine(station[destination - 1]);
                    Console.WriteLine($"Ticket Fare : {count} * 400 = {count * 400}");
                    Console.WriteLine("Time to Reach: 1 day 18 hours");
                    break;
                default:
                    Console.WriteLine("Select Correct station!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
