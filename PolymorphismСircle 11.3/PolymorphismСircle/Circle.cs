using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismСircle
{
    internal class Circle
    {
        private double r;

        public Circle()
        {
            r = 0.0;
        }
        public Circle(double R)
        {
            r = Math.Abs(R);
        }
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public virtual double Area()
        {
            return Math.PI * r * r;
        }
        public virtual void Zoom(double x)
        {
            r *= Math.Abs(x);
        }
        public virtual string Information()
        {
            return $"Circle: Сircle radius = {r}, Area of the circle = {Area():F2}";
        }
    }
}
