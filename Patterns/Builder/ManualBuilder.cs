using System;

namespace Patterns.Builder
{
    class ManualBuilder : IBuilder
    {
        private Manual manual;

        public IBuilder Reset()
        {
            this.manual = new Manual();
            return this;
        }

        public IBuilder SetEngine(string engine)
        {
            if (string.IsNullOrWhiteSpace(engine))
                throw new ArgumentNullException(nameof(engine));

            this.manual.Engine = engine;
            return this;
        }

        public IBuilder SetGPS(string gps)
        {
            if (string.IsNullOrWhiteSpace(gps))
                throw new ArgumentNullException(nameof(gps));

            this.manual.GPS = gps;
            return this;
        }

        public IBuilder SetSeats(string seats)
        {
            if (string.IsNullOrWhiteSpace(seats))
                throw new ArgumentNullException(nameof(seats));

            this.manual.Seats = seats;
            return this;
        }

        public IBuilder SetTripComputer(string tripComputer)
        {
            if (string.IsNullOrWhiteSpace(tripComputer))
                throw new ArgumentNullException(nameof(tripComputer));

            this.manual.TripComputer = tripComputer;
            return this;
        }

        public IProduct GetResult()
        {
            return manual;
        }
    }
}
