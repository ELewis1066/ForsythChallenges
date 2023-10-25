using Core;
using System;

namespace Selection
{
    namespace Easy
    {
        internal class Rainbow : Problem
        {
            public override string Name => "Easy.Rainbow";

            public Rainbow() { }

            static string[] coloursOfRainbow = new string[] { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            string IsColoursInRainbow(string colour)
            {
                /// How the answer looks like without the need of an array
                /// (my opinoun the inout and output examples aren't phrased properly)
                if (coloursOfRainbow.Contains(colour))
                {
                    return $"{colour} is in rainbow.";
                }
                else
                {
                    return $"{colour} is not in rainbow.";
                }
            }
                /// Code for previous interpretation of the question
                /*
                bool firstColorFound = false;
                bool secondColorFound = false;

                for (int i = 0; i < colours.Length; i++)
                {
                    for (int j = 0; j < coloursOfRainbow.Length; j++)
                    {
                        if (colours[i].ToLower() == coloursOfRainbow[j])
                        {
                            if (i == 0)
                            {
                                firstColorFound = true;
                            }
                            else if (i == 1)
                            {
                                secondColorFound = true;
                            }
                        }
                    }
                }

                if (firstColorFound && secondColorFound)
                {
                    return @$"{colours[0]} is in the rainbow
{colours[1]} is in the rainbow";
                }
                else if (firstColorFound)
                {
                    return $@"{colours[0]} is in the rainbow
{colours[1]} is not in the rainbow";
                }
                else if (secondColorFound)
                {
                    return $@"{colours[0]} is not the rainbow
{colours[1]} is in the rainbow";
                }
                else
                {
                    return $@"{colours[0]} is not the rainbow
{colours[1]} is not the rainbow";
                }
            }
               */

            public override void Execute()
            {
                /// Question was read incorrectly
                /// all code in green takes in array
                /// checks if the position of the first array is in
                /// the set array (colours in the rainbow)
                /// if it is, the first positoin is set to true
                /// then checks the other position of the colour
                /// and sets it to true or false

                /*
                Console.Write("Enter two colours comma seperated e.i { blue,red }: ");
                string[] inputColours = Console.ReadLine().Replace(" ", string.Empty).Split(",");
                Console.WriteLine(IsColoursInRainbow(inputColours));
                */

                Console.Write("Enter a colour: ");
                string colourInput = Console.ReadLine();
                Console.WriteLine(IsColoursInRainbow(colourInput));

            }
        }
    }
}
