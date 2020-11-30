using System;

namespace garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by like Rumble RumBLe!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram steers safely to the {direction}");
        }
    }
}