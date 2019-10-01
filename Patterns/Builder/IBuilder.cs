namespace Patterns.Builder
{
    interface IBuilder
    {
        IBuilder Reset();
        IBuilder SetSeats(string seats);
        IBuilder SetEngine(string engine);
        IBuilder SetTripComputer(string tripComputer);
        IBuilder SetGPS(string gps);
        IProduct GetResult();
    }
}
