using System;

namespace PolymorphismСircle
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the radius of the circle: ");
            double radiusCircle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the inner radius of the ring: ");
            double radiusInnerRing = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radiusCircle);
            Circle ring = new Ring(radiusInnerRing, radiusCircle);

            Console.WriteLine(circle.Information());
            Console.WriteLine(ring.Information());

            Console.Write("Enter how many times to enlarge the circle and ring: ");
            double x = Convert.ToDouble(Console.ReadLine());
            circle.Zoom(x);
            ring.Zoom(x);

            Console.WriteLine(circle.Information());
            Console.WriteLine(ring.Information());

        }
    }
}
