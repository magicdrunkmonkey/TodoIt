using System;
using TodoIt.Model;

namespace TodoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person Bertil = new Person(14, "Bertil", "Larsson");
            //Exempel: string name = Bertil.FirstName;
        }
    }
}
