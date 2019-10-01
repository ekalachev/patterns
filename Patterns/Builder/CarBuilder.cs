using System;

namespace Patterns.Builder
{
    class CarBuilder : IBuilder
    {
        private Car car;

        public IBuilder Reset()
        {
            this.car = new Car();
            return this;
        }

        public IBuilder SetEngine(string engine)
        {
            if (string.IsNullOrWhiteSpace(engine))
                throw new ArgumentNullException(nameof(engine));

            this.car.Engine = engine;
            return this;
        }

        public IBuilder SetGPS(string gps)
        {
            if (string.IsNullOrWhiteSpace(gps))
                throw new ArgumentNullException(nameof(gps));

            this.car.GPS = gps;
            return this;
        }

        public IBuilder SetSeats(string seats)
        {
            if (string.IsNullOrWhiteSpace(seats))
                throw new ArgumentNullException(nameof(seats));

            this.car.Seats = seats;
            return this;
        }

        public IBuilder SetTripComputer(string tripComputer)
        {
            if (string.IsNullOrWhiteSpace(tripComputer))
                throw new ArgumentNullException(nameof(tripComputer));

            this.car.TripComputer = tripComputer;
            return this;
        }

        public IProduct GetResult()
        {
            return car;
        }
    }
}
