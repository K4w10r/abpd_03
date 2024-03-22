using apbd_03.exceptions;
using apbd_03.interfaces;

namespace apbd_03.containers;

public class Container : IContainer
{
     protected double CargoMass { get; set; }
     protected double Height { get; set; }
     protected double Weight { get; set; }
     protected double Depth { get; set; }
     protected string Serial { get; set; }


     public Container(double height, double weight, double depth)
     {
          CargoMass = 0.0;
          Height = height;
          Weight = weight;
          Depth = depth;
          Serial = "KON-";
     }

     public virtual double GetCapacity()
     {
          //10 kg per square meter
          return (Weight/100) * (Height/100) * 10;
     }

     public virtual void Unload()
     {
          CargoMass = 0.0;
     }

     public virtual bool Load(double cargoWeight)
     {
          if (GetCapacity() < (cargoWeight + CargoMass))
          {
               throw new OverfillException();
          }
          else
          {
               CargoMass = cargoWeight;
               return true;
          }
     }

     public string GetSerial()
     {
          return Serial;
     }

     public double TotalWeight()
     {
          return CargoMass + Weight;
     }

     public override string ToString()
     {
          return "Serial: " + Serial + ", Cargo mass: " + CargoMass + ", Total weight: " + TotalWeight() 
                 + ", Height: " + Height + ", Depth: " + Depth;
     }
     //trzeba w kazdej klasie override
}
