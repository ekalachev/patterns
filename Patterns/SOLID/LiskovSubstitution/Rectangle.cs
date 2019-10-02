namespace DesignPatterns.SOLID.LiskovSubstitution
{
    // using a classic example
    public class RectangleWithViolatingLiskovSubstitutionPrinciple
    {
        // This code will violate the Liskov substitution principle
        public int Width { get; set; }
        public int Height { get; set; }

        public RectangleWithViolatingLiskovSubstitutionPrinciple()
        {
        }

        public RectangleWithViolatingLiskovSubstitutionPrinciple(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"Violates LSP: {nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    public class Rectangle
    {
        // This commented code will violate the Liskov substitution principle
        //public int Width { get; set; }
        //public int Height { get; set; }

        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}
