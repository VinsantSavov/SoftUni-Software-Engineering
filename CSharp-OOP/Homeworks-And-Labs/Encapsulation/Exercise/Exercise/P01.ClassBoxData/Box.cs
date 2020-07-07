using System;
using System.Text;

namespace P01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double heigth)
        {
            if(length <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            if(width <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            if(heigth <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.length = length;
            this.width = width;
            this.heigth = heigth;
        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * this.length * this.width + 2 * this.length * this.heigth + 2 * this.width * this.heigth;

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralArea = 2 * this.length * this.heigth + 2 * this.width * this.heigth;

            return lateralArea;
        }

        public double Volume()
        {
            double volume = this.length * this.heigth * this.width;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():F2}");
            sb.AppendLine($"Volume - {this.Volume():F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
