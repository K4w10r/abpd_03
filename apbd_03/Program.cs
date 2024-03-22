// See https://aka.ms/new-console-template for more information

using apbd_03;
using apbd_03.containers;
using apbd_03.interfaces;

int id = 0;
LiquidContainer liquidContainer = new LiquidContainer(
    500.0, 1000, 500.0, id += 1, true
    );
liquidContainer.Load(500.0);
var ship = new Ship(1000, 50, 100000);
ship.AddContainer(liquidContainer);
List<IContainer> list = new List<IContainer>();
list.Add(new GasContainer(400,1000,500,id += 1));
list.Add(new RefrigeratedContainer(500, 1000, 500,id+=1));

ship.AddContainer(list);
ship.Display();

ship.RemoveContainer(liquidContainer.GetSerial());
ship.Display();

liquidContainer.Unload();
Console.WriteLine(liquidContainer.ToString());

GasContainer gasContainer = new GasContainer(1000, 2000,1000,id+=1);
gasContainer.Load(500);

ship.ReplaceContainer(gasContainer, "KON-G-2");
ship.Display();

Ship ship1 = new Ship(15,13,100000);

void SwapShips(Ship from, Ship to, IContainer container)
{
    from.RemoveContainer(container.GetSerial());
    to.AddContainer(container);
}

SwapShips(ship, ship1, gasContainer);
ship1.Display();