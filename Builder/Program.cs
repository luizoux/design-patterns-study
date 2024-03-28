﻿using Builder.Builders;
using Builder.Directors;
using Builder.Products;

namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        VehicleBuilder builder = new VehicleBuilder();
        Director director = new Director(builder);

        director.ConstructSedanCar();

        Vehicle sedan = builder.GetVehicle();
        Console.WriteLine($"Criado uma veículo do tipo: {sedan.VehicleType}");

        director.ConstructTruck();

        Vehicle truck = builder.GetVehicle();
        Console.WriteLine($"Criado uma veículo do tipo: {truck.VehicleType}");

        director.ConstructSUV();

        Vehicle suv = builder.GetVehicle();

        Console.WriteLine($"Criado uma veículo do tipo: {suv.VehicleType}");
        Console.ReadLine();
    }
}
