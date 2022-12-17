using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class InsulatedWire : Cylinder
    {
        private double weight;
        private double isolation;
        private double isoWeight;

        public InsulatedWire(double diameter, double height, double weightm, double isolation, double isoWeight) : base(diameter, height)
        {
            this.weight = weight;
            this.isolation = isolation;
            this.isoWeight = isoWeight;
        }

        public double Weight
        {
            get { return weight; }
            set { if (value > 0) weight = value; }
        }

        public double Isolaion
        {
            get { return isolation; }
            set { if (value > 0) isolation = value; }
        }
        public double IsoWeight
        {
            get { return isoWeight; }
            set { if (value > 0) isoWeight = value; }
        }

        public double GetWeight()
        {
            return Math.PI * Math.Pow(( Diameter / 2), 2) + 2 * Math.PI * isolation * isoWeight;
        }

        public override string? ToString()
        {
            return $"Вес изолированного провода - {GetWeight()}";
        }
    }
}
