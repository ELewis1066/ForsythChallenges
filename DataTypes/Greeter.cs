using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    namespace Easy
    {
        public class Greeter : Problem
        {
            public override string Name => "Easy.Greeter";

            public Greeter() { }


            public override void Execute()
            {   
                Console.Write("Enter your name: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                    Console.WriteLine("Hello " + input);
            }

        }
    }
}
