namespace Patterns.Builder
{
    class Director
    {
        public IProduct ConstructSportCar(IBuilder builder)
        {
            return builder
                .Reset()
                .SetSeats("2")
                .SetEngine("sport engine")
                .SetTripComputer("sport trip computer")
                .SetGPS("GPS")
                .GetResult();
        }
    }
}
