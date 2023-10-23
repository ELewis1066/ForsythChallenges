using Core;


namespace DataTypes
{
    namespace Hard
    {
        public class Validator : Problem
        {
            public override string Name => "Hard.Validator";

            public Validator() { }
            static string FindingValue(string[] values)
            {
                try
                {
                    // keeps count of the values entered
                    int valueConunter = 0;

                    // goes through each value and add them to value count
                    for (int i = 0; i < values.Length; i++)
                    {
                        // formula to find the value for each item
                        valueConunter += (values[i].ToLower() == "true") ? (int)Math.Pow(2, values.Length - 1 - i) : 0;
                    }

                    return $"{valueConunter}";
                }
                catch (Exception e) 
                {
                    return $"{e.Message}";
                }
            }

            public override void Execute()
            {
                Console.Write("Enter three true/false values comma sperated: ");
                string[] values = Console.ReadLine().Replace(" ", string.Empty).Split(",");
                Console.WriteLine(FindingValue(values));
            }

        }
    }
    
}
