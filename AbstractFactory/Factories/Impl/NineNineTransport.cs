using AbstractFactory.Aircrafts;
using AbstractFactory.Aircrafts.Impl;
using AbstractFactory.LandVehicles;
using AbstractFactory.LandVehicles.Impl;

namespace AbstractFactory.Factories.Impl;

class NineNineTransport : ITransportFactory
{
    public IAircraft CreateTransportAircraft()
    {
        return new Helicopter();
    }

    public ILandVehicle CreateTransportVehicle()
    {
        return new Motorcycle();
    }
}
