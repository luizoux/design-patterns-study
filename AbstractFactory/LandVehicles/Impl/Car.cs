﻿namespace AbstractFactory.LandVehicles.Impl;

class Car : ILandVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Pegamos os passageiros, estamos prontos!");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciando o trajeto.");
    }
}
