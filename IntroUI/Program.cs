using System;
using IntroLib;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel
            {
                FirstName = "Timok",
                LastName = "correy"                
            };
            System.Console.WriteLine( $"{p.FirstName} {p.LastName} is my name. "  );
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(p.NameBuilder());
            
            


        }
    }
}
