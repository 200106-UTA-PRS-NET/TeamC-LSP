using System;

namespace NoLSPShapes
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }
    public class Rectangle: Shape
    {
        public override double Area { get { return Length * Width; } }
        public virtual double Width { set; get; }
        public virtual double Length { set; get; }
    }
    public class Square: Rectangle
    {
        double side;
        public override double Width { set { side = value; } get { return side; } }
        public override double Length { set { side = value; } get { return side; } }
    }
}
