using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public Ram()
        {
            CurrentTankPercentage = 0;
        }

        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
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