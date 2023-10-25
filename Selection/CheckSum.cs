using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    namespace Hard
    {
        internal class CheckSum : Problem
        {
            public override string Name => "Hard.CheckSum";

            public CheckSum() { }

            // little bit of code is useful to know
            // it gives you the sum of all digits
            public static int SumOfDigits(int n)
            {
                n = Math.Abs(n);
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
            }

            public bool IsValidCreditCard(string cardNumber)
            {
                if (string.IsNullOrEmpty(cardNumber)) return false;
                if (cardNumber.Length != 16) return false;

                // turning the string into an array
                int[] numbers = cardNumber.Select(x => Int32.Parse(x.ToString())).ToArray();

                // for every 2nd card starting at position 0, muktiply them by 2
                // if the number multiplied by 2 is greater then 10 ( as it has two digits) )
                // it will call the function *SumOfAllDigits*
                for (int i=0; i<15; i+=2)
                {
                    int tmp = numbers[i] * 2;
                    if (tmp >= 10)
                    {
                        numbers[i] = SumOfDigits(tmp);
                    }
                    else
                    {
                        numbers[i] = tmp;
                    }
                }

                // This could be merged into the first loop,
                // clearly, but the code is clear and its still O(N).
                int sum = 0;
                for (int i=0; i < 15; i++)
                {
                    sum += numbers[i];
                }

                // The check digit, do this step outside of loop for clarity.
                sum += numbers[15]; 
                return sum % 10 == 0;
            }
            public override void Execute()
            {
                Console.Write("What is the credit card number (no spaces):");
                string input = Console.ReadLine();

                // checks whether or not it is valid
                if (IsValidCreditCard(input))
                {
                    Console.WriteLine($"The number {input} is valid.");
                }
                else
                {
                    Console.WriteLine($"The number {input} is not valid.");
                }   
            }
        }

    }
    
}
