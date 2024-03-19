namespace AbstractFactory.LandVehicles.Impl
{
    class Motorcycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Inciamos a entrega.");
        }
    }
}
