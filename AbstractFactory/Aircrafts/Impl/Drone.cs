namespace AbstractFactory.Aircrafts.Impl;

class Drone : IAircraft
{
    public void GetCargo()
    {
        Console.WriteLine("Pegamos a carga, estamos prontos!");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciando o trajeto.");
    }
}
