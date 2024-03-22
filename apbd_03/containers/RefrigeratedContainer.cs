namespace apbd_03.containers;

public class RefrigeratedContainer: Container
{
    private string TypeOfProduct { set; get; }
    private double Temperature { set; get; }
    public RefrigeratedContainer(double height, double weight, double depth,int id) : base(height, weight, depth)
    {
        TypeOfProduct = "empty";
        base.Serial += "C-" + id;
    }
    
    public void Load(double cargoWeight,string type,double temp)
    {
        if (TypeOfProduct.Equals("empty"))
        {
            base.Load(cargoWeight);
            Temperature = temp;
        }else if (TypeOfProduct.Equals(type))
        {
            base.Load(cargoWeight);
        }
    }

    public new void Unload()
    {
        base.Unload();
        Temperature = 0.0;
        TypeOfProduct = "empty";
    }

    public override string ToString()
    {
        return base.ToString() + ", Type of product: " + TypeOfProduct + ", Temperature: " + Temperature;
    }
}