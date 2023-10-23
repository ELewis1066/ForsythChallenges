using Core;


namespace DataTypes
{
    namespace Medium
    {
        public class Speedy : Problem
        {
            public override string Name => "Medium.SPEEDY";

            public Speedy() { }

            const double RATIO_BETWEEN_MPH_AND_KPH = 1.60934;
            public override void Execute()
            {
                Console.Write("Enter your speed(m / h): ");
                double milesPerHour = Convert.ToDouble(Console.ReadLine());

                // convertion miles per hour to kilometers per hour
                double kilometersPerHour = milesPerHour * RATIO_BETWEEN_MPH_AND_KPH;
                Console.WriteLine($"{milesPerHour} miles per hour is the same as {kilometersPerHour.ToString("F1")}");
            }
        }
    }
}
