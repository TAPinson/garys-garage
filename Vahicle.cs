using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

    public virtual void Turn(string direction)
    {
        Console.WriteLine($"The Vehicle makes a {direction} turn.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Your vehicles comes to a stop.");
    }
}