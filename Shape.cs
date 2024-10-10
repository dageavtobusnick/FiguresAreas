namespace FiguresAreas
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public static double CalculateArea(Shape shape)
        {
            return shape.GetArea();
        }
    }
}
