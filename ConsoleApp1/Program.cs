using System;
using System.Transactions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine("Enter time value");
            time=Convert.ToInt32(Console.ReadLine());
            if(time<=11)
            {
                Console.WriteLine("good morning");
            }
            else if(time<=15)
            {
                Console.WriteLine("Good noon");
            }
            else if(time<=17)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (time<=22) {
                Console.WriteLine("Good evening");
            }
            else if (time <= 24)
            {
                Console.WriteLine("Good night");

            }
            else
            {
                Console.WriteLine("time is not correct");
            }
        }

    }
}
