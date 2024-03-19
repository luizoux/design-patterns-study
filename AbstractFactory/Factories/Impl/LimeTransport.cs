using AbstractFactory.Aircrafts;
using AbstractFactory.Aircrafts.Impl;
using AbstractFactory.LandVehicles;
using AbstractFactory.LandVehicles.Impl;

namespace AbstractFactory.Factories.Impl;

class LimeTransport : ITransportFactory
{
    public IAircraft CreateTransportAircraft()
    {
        return new Drone();
    }

    public ILandVehicle CreateTransportVehicle()
    {
        return new Scooter();
    }
}
