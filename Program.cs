using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator youtuber = new Youtuber();
            Creator programmer = new Programmer();


            Console.WriteLine("---Youtuber---");
            youtuber.Create();

            Console.WriteLine("---Programmer---");
            programmer.Create();
        }

    }
}

