using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Cylinder
    {
        private double diameter;
        private double height;
        private double radius;

        public Cylinder(double diameter, double height)
        {
            this.diameter = diameter;
            this.height = height;
        }

        public double Diameter
        {
            get { return diameter; }
            set { if (value > 0) diameter = value; }
        }
        public double Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }
    }
}
