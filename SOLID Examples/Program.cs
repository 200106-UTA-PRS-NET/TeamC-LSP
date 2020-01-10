using System;

namespace SOLID_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            NoLSPShapes.Rectangle noLSPRectangle;
            Console.WriteLine("Demoing non-SLP class structure\n\nShape{Area}\n  |\nRectangle{Length, Width}\n  |\nSquare\n");
            noLSPRectangle = new NoLSPShapes.Rectangle() { Length = 5, Width = 10 };
            Console.WriteLine($"Area of the Rectangle (L=5, W=10): {noLSPRectangle.Area}");
            noLSPRectangle = new NoLSPShapes.Rectangle() { Length = 10, Width = 5 };
            Console.WriteLine($"Area of the Rectangle (L=10, W=5): {noLSPRectangle.Area}");
            noLSPRectangle = new NoLSPShapes.Square() { Length = 5, Width = 10 };
            Console.WriteLine($"Area of the Square (L=5, W=10): {noLSPRectangle.Area}");
            noLSPRectangle = new NoLSPShapes.Square() { Length = 10, Width = 5 };
            Console.WriteLine($"Area of the Square (L=10, W=5): {noLSPRectangle.Area}");
            noLSPRectangle = new NoLSPShapes.Square() { Width = 5, Length = 10 };
            Console.WriteLine($"Area of the Square (W=5, L=10): {noLSPRectangle.Area}");
            noLSPRectangle = new NoLSPShapes.Square() { Width = 10, Length = 5 };
            Console.WriteLine($"Area of the Square (W=10, L=5): {noLSPRectangle.Area}");

            Console.ReadLine();
            LSPShapes.Rectangle LSPRectangle;
            LSPShapes.Square LSPSquare;
            Console.WriteLine("Demoing SLP class structure\n\nShape{Area}\n | |\n | Rectangle{Length, Width}\n |\nSquare{Side}\n");
            LSPRectangle = new LSPShapes.Rectangle() { Length = 5, Width = 10 };
            Console.WriteLine($"Area of the Rectangle (L=5, W=10): {LSPRectangle.Area}");
            LSPRectangle = new LSPShapes.Rectangle() { Length = 10, Width = 5 };
            Console.WriteLine($"Area of the Rectangle (L=10, W=5): {LSPRectangle.Area}");
            LSPSquare = new LSPShapes.Square() { Side = 5 };
            Console.WriteLine($"Area of the Square (Side=5): {LSPSquare.Area}");
            LSPSquare = new LSPShapes.Square() { Side = 10 };
            Console.WriteLine($"Area of the Square (Side=10): {LSPSquare.Area}");
        }
    }
}
