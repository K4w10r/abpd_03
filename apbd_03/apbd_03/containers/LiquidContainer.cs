namespace apbd_03.containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoMass) : base(cargoMass)
    {
    }
    
    public new void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }
}