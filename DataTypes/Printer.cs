using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    namespace Easy {
        public class Printer : Problem
        {
            static int REPEAT_COUNT = 10;

            public override string Name => "Easy.Printer";

            public Printer() { }
        
            public override void Execute()
            {
                // recieves input
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // conversion, double, times ten, concat/enumerable repeat; functions

                //int conversion = Int32.Parse(input); // could use this, it will throw an Exception.
                if (uint.TryParse(input, out uint conversion))
                {
                    uint doubled = conversion * 2;
                    uint timesTen = conversion * 10;
                    string repeatingString = string.Concat(Enumerable.Repeat(input, REPEAT_COUNT));

                    // ouputs
                    Console.WriteLine($"Your number: {input}");
                    Console.WriteLine($"Doubled: {doubled}");
                    Console.WriteLine($"Times ten: {timesTen}");
                    Console.WriteLine($"Repeated ten times : {repeatingString}");
                }
                else
                {
                    Console.WriteLine($"Invalid input {input}");
                }
            }
        }
    }
}
