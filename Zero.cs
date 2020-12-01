using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {

        public Zero()
        {
            CurrentChargePercentage = 0;
        }

        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives by like Meeeehhhhhhhhhhhhh!");
        }
    }
}