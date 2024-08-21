namespace OpenClosedPrinciple
{
    // A base class for shapes.
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // New shapes can be added without changing the Shape class.
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return Side * Side;
        }
    }

}