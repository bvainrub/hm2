using System;
using IntroLib;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p1 = new PersonModel
            {
                FirstName = "Timok",
                LastName = "correy"                
            };
            PersonModel p2 = new PersonModel{

                 FirstName ="Anna",
                LastName = "Frank"
            };
            System.Console.WriteLine( $"{p1.FirstName} {p1.LastName} is my name. "  );
            System.Console.WriteLine(p1.NameBuilder());
            System.Console.WriteLine($"{p2.FirstName} {p2.LastName} is second name ");
            System.Console.WriteLine("Hello World");
        }


        
    }
}

