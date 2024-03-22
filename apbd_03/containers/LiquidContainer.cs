using apbd_03.exceptions;
using apbd_03.interfaces;

namespace apbd_03.containers;

public class LiquidContainer : Container, IHazardNotifier
{
    protected bool IsHazardous;
    public LiquidContainer(double height, double weight, double depth, int id, bool hazardous) : base(height, weight, depth)
    {
        Serial += "L-" + id;
        IsHazardous = hazardous;
    }

    public new double GetCapacity()
    {
        double res;
        if (IsHazardous)
        {
            res = base.GetCapacity() / 2;
        }
        else res = base.GetCapacity() * 0.9;

        return res;
    }
    public new void Load(double cargoWeight)
    {
        if(base.Load(cargoWeight) && cargoWeight > GetCapacity())Notify();
    }

    public void Notify()
    {
        Console.WriteLine("Hazardous violation at: " + Serial);
    }

    public override string ToString()
    {
        return base.ToString() + ", Is hazardous: " + IsHazardous;
    }
}