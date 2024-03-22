namespace apbd_03.interfaces;

public interface IContainer
{
    void Unload();
    bool Load(double cargoWeight);
    string GetSerial();
}