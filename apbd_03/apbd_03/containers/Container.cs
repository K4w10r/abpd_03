using apbd_03.interfaces;

namespace apbd_03.containers;

public class Container : IContainer
{
     public double CargoMass { get; set; }

     public Container(double cargoMass)
     {
          CargoMass = cargoMass;
     }

     public void Unload()
     {
          throw new NotImplementedException();
     }

     public virtual void Load(double cargoWeight)
     {
          throw new NotImplementedException();
     }
}