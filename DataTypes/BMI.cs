using Core;

namespace DataTypes
{
    namespace Medium
    {
        public class BMI : Problem
        {
            public override string Name => "Medium.BMI";

            public BMI() { }


            public override void Execute()
            {
                // questions needed
                Console.Write("Enter you weight(Kg): ");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter you height(cm): ");
                double height = Convert.ToDouble(Console.ReadLine());

                // convertion from cm to m
                double centimeterToMeters = height / 100;

                // BMI calcultions
                double BMI = weight / (centimeterToMeters * centimeterToMeters);
                Console.WriteLine($"Your BMI is {BMI.ToString("F1")}");
            }
        }

    }
   
}
