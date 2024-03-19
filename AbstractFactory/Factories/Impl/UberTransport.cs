using AbstractFactory.Aircrafts;
using AbstractFactory.Aircrafts.Impl;
using AbstractFactory.LandVehicles;
using AbstractFactory.LandVehicles.Impl;

namespace AbstractFactory.Factories.Impl;

class UberTransport : ITransportFactory
{
    public IAircraft CreateTransportAircraft()
    {
        return new Airplane();
    }

    public ILandVehicle CreateTransportVehicle()
    {
        return new Car();
    }
}
