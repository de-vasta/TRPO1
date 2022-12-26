namespace TRPO1.Models;

class Plane : Vehicle
{
    public Plane(string name, int maxSpeed) : base(type: VehicleType.Air, name: name, maxSpeed: maxSpeed) { }
}