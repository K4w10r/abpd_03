using apbd_03.interfaces;

namespace apbd_03.containers;

public class GasContainer : Container, IHazardNotifier
{
    protected double Pressure;
    public GasContainer(double height, double weight, double depth, int id) : base(height, weight, depth)
    {
        Serial += "G-" + id;
    }

    private void SetPressure()
    {
        Pressure = (CargoMass * 10) / (Depth * Depth);
    }

    public new void Unload()
    {
        CargoMass *= 0.5;
        SetPressure();
    }

    public new void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        SetPressure();
    }

    public void Notify()
    {
        Console.WriteLine("Hazardous event: " + Serial);
    }

    public override string ToString()
    {
        return base.ToString() + ", Pressure: " + Pressure;
    }
}