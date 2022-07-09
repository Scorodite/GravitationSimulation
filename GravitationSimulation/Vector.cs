using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationSimulation
{
    /// <summary>
    /// Struct that represents 2D vector
    /// </summary>
    public struct Vector
    {
        public double X
        {
            get => Math.Cos(Angle) * Lenght;
            set
            {
                double y = Y;
                double angle = Math.Atan2(y, value);
                Angle = double.IsNaN(angle) ? 0 : angle;
                Lenght = Math.Sqrt(Math.Pow(value, 2) + Math.Pow(y, 2));
            }
        }
        public double Y
        {
            get => Math.Sin(Angle) * Lenght;
            set
            {
                double x = X;
                double angle = Math.Atan2(value, x);
                Angle = double.IsNaN(angle) ? 0 : angle;
                Lenght = Math.Sqrt(Math.Pow(value, 2) + Math.Pow(x, 2));
            }
        }

        public Angle Angle { get; set; }

        public double Lenght { get; set; }

        public Vector(Angle angle, double value) : this()
        {
            Angle = angle;
            Lenght = value;
        }

        /// <summary>
        /// Summarises two vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector operator &(Vector a, Vector b)
        {
            if (a.Lenght == 0)
            {
                return b;
            }
            else if (b.Lenght == 0)
            {
                return a;
            }
            Angle offset = Math.Min(a.Angle, b.Angle);
            a.Angle -= offset;
            b.Angle -= offset;
            if (a.Angle > b.Angle)
            {
                (a, b) = (b, a);
            }
            double cos = (a.X * b.X + a.Y * b.Y) /
                (Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2)) * Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2)));
            double value = Math.Sqrt(Math.Pow(a.Lenght, 2) + Math.Pow(b.Lenght, 2) + 2 * a.Lenght * b.Lenght * cos);
            double finalCos = Math.Clamp((Math.Pow(a.Lenght, 2) + Math.Pow(value, 2) - Math.Pow(b.Lenght, 2)) /
                           (2 * a.Lenght * value), -1, 1);
            Angle angle = Math.Acos(finalCos);
            if (b.Angle > Math.PI)
            {
                angle = -angle;
            }
            return new Vector()
            {
                Lenght = HasValue(value) ? value : 0,
                Angle = HasValue(angle) ? angle + offset : 0
            };
        }

        private static bool HasValue(double value)
        {
            return !double.IsNaN(value) && !double.IsInfinity(value);
        }
    }
}
