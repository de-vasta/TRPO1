namespace TRPO1.Models;

enum VehicleType { Ground, Air, Water }

abstract class Vehicle
{
    public readonly VehicleType type;

    public string Name { get; set; }

    /// <summary>
    ///  Measured in kmph.
    /// </summary>
    public readonly int maxSpeed;

    public Vehicle(VehicleType type, string name, int maxSpeed)
    {
        Name = name;
        this.maxSpeed = maxSpeed;
        this.type = type;
    }

    protected Vehicle(string name, int maxSpeed)
    {
        Name = name;
        this.maxSpeed = maxSpeed;
    }

    public string ToString(string delimiter) => $"Type 👉 {type.ToString()}{delimiter}Name 👉 {Name}{delimiter}Max speed 👉 {maxSpeed}";
    public override string ToString() => ToString("; ");
}