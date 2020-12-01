using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle  // Electric car
    {
        public Tesla()
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
            Console.WriteLine($"The {MainColor} Tesla drives by like *silence*");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla rolls to a stop when the battery dies because you tried to drive it on a practical road trip");
        }
    }
}