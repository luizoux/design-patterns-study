namespace AbstractFactory.LandVehicles.Impl;

class Scooter : ILandVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Encomenda na mochila!");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciando entraga com patinete...");
    }
}
