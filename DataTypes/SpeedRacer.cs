using Core;


namespace DataTypes
{
    namespace Hard
    {
        public class SpeedRacer : Problem
        {
            public override string Name => "Hard.SpeedRacer";

            public SpeedRacer() { }

            const double UPPER_BOUND = 10.500;
            const double LOWER_BOUND = 9.500;

            public override void Execute()
            {
                // created a new object called stopwacth
                var timer = new Stopwatch();

                Console.WriteLine("Press enter to begin");

                // start of timer
                Console.ReadLine();
                timer.Start();

                Console.WriteLine("Press enter again when you think it has been exactly 10 seconds");

                // end of timer
                Console.ReadLine();
                timer.Stop();

                // measures how long it took
                TimeSpan timeTaken = timer.Elapsed;

                // extention: checks wether its within a certain range
                if (timeTaken.TotalSeconds <= UPPER_BOUND && timeTaken.TotalSeconds >= LOWER_BOUND)
                {
                    Console.WriteLine("Congrats you were within the range of 500ms");
                    Console.WriteLine($"You took {timeTaken.TotalSeconds.ToString("F3")} seconds "); // to 0.001's of a second
                }
                else
                {
                    Console.WriteLine($"You took {timeTaken.TotalSeconds.ToString("F3")} seconds ");
                }
            }
        }
    }
}
