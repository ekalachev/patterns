namespace DesignPatterns.Builder
{
    class Car : IProduct
    {
        public string Seats { get; set; }
        public string Engine { get; set; }
        public string TripComputer { get; set; }
        public string GPS { get; set; }

        public override string ToString()
        {
            return $"Car: {Engine}, {Seats}, {TripComputer}, {GPS}";
        }
    }
}
