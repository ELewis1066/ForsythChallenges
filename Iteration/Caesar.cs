using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Iteration
{
    namespace Medium
    {
        public class Caeser : Problem
        {
            public override string Name => "Medium.Caeser";

            List<char> Alphabet = new List<char> 
            { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            string CipherText(string plainText, int rotValue)
            {
                string cipheredText = "";

                foreach (char c in plainText)
                {
                    if (char.IsLetter(c))
                    {
                        char originalChar = char.ToUpper(c);
                        int index = Alphabet.IndexOf(originalChar);
                        if (index >= 0)
                        {
                            int newIndex = (index + rotValue) % Alphabet.Count;
                            char cipheredChar = char.IsUpper(c) ? Alphabet[newIndex] : char.ToLower(Alphabet[newIndex]);
                            cipheredText += cipheredChar;
                        }
                    }
                    else
                    {
                        cipheredText += c;
                    }
                }
                return cipheredText;
            }

            public override void Execute()
            {
                Console.Write("Enter a plain text: ");
                string plainText = Console.ReadLine();

                Console.Write("What rot value would you like to use? ");
                int rotValue = Convert.ToInt32(Console.ReadLine());

                string ciphered = CipherText(plainText, rotValue);

                Console.WriteLine("Ciphered text is: " + ciphered);
            }
        }
    }
}
