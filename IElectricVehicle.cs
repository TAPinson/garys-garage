namespace Garage
{
    public interface IElectricVehicle
    {
        void ChargeBattery();

        int CurrentChargePercentage { get; }
    }
}