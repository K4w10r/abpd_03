using apbd_03.interfaces;

namespace apbd_03;

public class Ship
{
    private List<IContainer> Containers;
    private double MaxSpeed;
    private int MaxContainerAmount;
    private double MaxWeight;

    public Ship(double maxSpeed, int maxContainerAmount, double maxWeight)
    {
        Containers = new List<IContainer>();
        MaxSpeed = maxSpeed;
        MaxContainerAmount = maxContainerAmount;
        MaxWeight = maxWeight;
    }

    public void AddContainer(IContainer container)
    {
        if(Containers.Count < MaxContainerAmount)Containers.Add(container);
    }

    public void AddContainer(List<IContainer> containers)
    {
        if ((Containers.Count + containers.Count) < MaxContainerAmount)
        {
            foreach (IContainer cont in containers)
            {
                Containers.Add(cont);
            }
        }
    }

    public void ReplaceContainer(IContainer to, string from)
    {
        if (RemoveContainer(from))AddContainer(to);
        
    }

    public bool RemoveContainer(String serial)
    {
        foreach (IContainer container in Containers)
        {
            if (container.GetSerial().Equals(serial))
            {
                Containers.Remove(container);
                return true;
                
            }
        }

        return false;
    }

    public void Display()
    {
        Console.WriteLine("Ships data: ");
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Max amount of containers: " + MaxContainerAmount);
        Console.WriteLine("Max weight: " + MaxWeight);
        Console.WriteLine("All containers: ");
        foreach (IContainer container in Containers)
        {
            Console.WriteLine(container.ToString());
        }
    }
}