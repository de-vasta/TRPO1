namespace TRPO1.Models;

class Ship : Vehicle
{
    public Ship(string name, int maxSpeed) : base(type: VehicleType.Water, name: name, maxSpeed: maxSpeed) { }
}