using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismСircle
{
    internal class Ring : Circle
    {
        private double r_in;

        public Ring()
        {
            r_in = 0.0;
        }
        public Ring(double r_in, double R)
        {
            this.r_in = r_in;
            this.R = R;
        }
        public override double Area()
        {
            return Math.PI * (R * R - r_in * r_in);
        }
        public override void Zoom(double x)
        {
            R *= Math.Abs(x);
            r_in *= Math.Abs(x);
        }
        public override string Information()
        {
            return $"Ring: Inner radius = {r_in} ,Outer radius = {R} ,Ring Area = {Area():F2}";
        }
    }
}
