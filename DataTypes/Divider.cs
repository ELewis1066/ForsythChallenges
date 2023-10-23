using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    namespace Easy
    {
        public class Divider : Problem
        {
            public override string Name => "Easy.Divider";
            public Divider() { }

            public override void Execute()
            {
                Console.Write("Enter larger number: ");
                double largerNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter smaller number: ");
                double smallerNumber = Convert.ToDouble(Console.ReadLine());


                if ( smallerNumber > largerNumber )
                {
                    Console.WriteLine($" {largerNumber} should be greater than  {smallerNumber}.");
                }
                else
                {
                    Console.WriteLine($"{largerNumber} divided by {smallerNumber} is: {largerNumber / smallerNumber}");

                    // interger division and modulo

                    // cast to an interger for interger division
                    int valueLarger = (int) largerNumber;
                    int valueSmaller = (int) smallerNumber;

                    // find remainder
                    int modulo = valueLarger % valueSmaller;

                    // finding the whole number
                    int intergerDivision = valueLarger / valueSmaller;

                    Console.WriteLine($"{largerNumber} divided by {smallerNumber} as an interger is: {intergerDivision} remainder {modulo}");
                }
            }

        }
    }
    
}
