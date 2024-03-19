namespace AbstractFactory.LandVehicles.Impl;

class Car : ILandVehicle
{
    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciando o trajeto.");
    }
}
