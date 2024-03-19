using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory)
        {

            vehicle = factory.CreateTransportVehicle();
            aircraft = factory.CreateTransportAircraft();

        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
