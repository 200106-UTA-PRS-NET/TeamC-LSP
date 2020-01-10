using System;

namespace LSPShapes
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }
    public class Rectangle : Shape
    {
        //double length, width;
        public override double Area { get { return Length * Width; } }
        public double Width { set; get; }
        public double Length { set; get; }
    }
    public class Square : Shape
    {
        public double Side { get; set; }
        public override double Area { get { return Side * Side; } }
    }
}
