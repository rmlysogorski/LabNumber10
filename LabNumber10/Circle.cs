using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber10
{
    class Circle
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            return 2.0 * Math.PI * Radius;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber (double x)
        {
            return x.ToString("0.00");
        }
    }
}
