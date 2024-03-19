using System;

namespace FactoryMethod.Vehicles;

class Bicycle : IVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Pegamos o alimento!");
    }

    public void StartRoute()
    {
        Console.WriteLine("Iniciando o trajeto.");
        GetCargo();
    }
}