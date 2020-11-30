using System;

namespace garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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