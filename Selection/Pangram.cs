using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    namespace Hard
    {
        public class Pangram : Problem
        {
            public override string Name => "Hard.Pangram";

            public Pangram() { }
            bool IsPangram(string input)
            {
                // HashSet makes sure that once a letter has been found
                // it will stop counting for that letter and only look for 
                // any unique letters
                HashSet<char> alphabetSet = new HashSet<char>();

                // .ToUpper to turn everything capitalised
                string inputUpperCase = input.ToUpper();

                foreach (char c in inputUpperCase)
                {
                    // Relies on fact HashSet can't containt duplicates.
                    if (Char.IsLetter(c)) 
                    {
                        alphabetSet.Add(c);
                        // Avoid traversing whole input if we already have
                        // all letters of the alphabet.
                        if (alphabetSet.Count == 26) return true;
                    }
                }

                return alphabetSet.Count == 26;
            }

            public override void Execute()
            {
                Console.Write("Enter your sentence: ");
                string inputSentence = Console.ReadLine();

                // bool is used because it is, or it isnt a pangram
                bool isPangram = IsPangram(inputSentence);
                if (isPangram)
                {
                    Console.WriteLine("The input is a pangram.");
                }
                else
                {
                    Console.WriteLine("The input is not a pangram.");
                }
            }
        }
    }
}
