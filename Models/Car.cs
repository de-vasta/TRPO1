namespace TRPO1.Models;

class Car : Vehicle
{
    public Car(string name, int maxSpeed) : base(type: VehicleType.Ground, name: name, maxSpeed: maxSpeed) { }
}