using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEncapsulation
{
    public class Box
    {
        private double height;
        private double width;
        private double length;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double area = 2 * (Length * Width + Length * Height + Width * Height);
            return area;
        }

        public double LateralSurfaceArea()
        {
            double result = 2 * (Length * Height + Width * Height);

            return result;
        }

        public double Volume()
        {
            double result = Length * Width * Height;
            return result;
        }

    }
}
