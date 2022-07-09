using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationSimulation
{
    /// <summary>
    /// Struct that represents angle in radians
    /// </summary>
    public struct Angle
    {
        private const double DOUBLE_PI = Math.PI * 2;

        public double Value
        {
            get => _Value;
            set
            {
                double val = value % DOUBLE_PI;
                _Value = val < 0 ?
                    (val + DOUBLE_PI) % DOUBLE_PI :
                    val;
            }
        }
        private double _Value;
        public double Degrees
        {
            get => Value / Math.PI * 180;
            set => Value = value / 180 * Math.PI;
        }

        public Angle(double angle) : this()
        {
            Value = angle;
        }

        public static Angle PosToAngle(double x1, double y1, double x2, double y2)
        {
            return new Angle(Math.Atan2(y1 - y2, x1 - x2));
        }

        public static implicit operator double(Angle angle) =>
            angle.Value;
        public static implicit operator Angle(double angle) =>
            new(angle);

        public static Angle operator +(Angle a, Angle b)
        {
            return new Angle(a.Value + b.Value);
        }
        public static Angle operator -(Angle a, Angle b)
        {
            return new Angle(a.Value - b.Value);
        }

        public static bool operator >(Angle a, Angle b)
        {
            return a.Value > b.Value;
        }
        public static bool operator <(Angle a, Angle b)
        {
            return a.Value < b.Value;
        }

        public override string ToString()
        {
            return (Value / Math.PI).ToString() + "π";
        }
    }
}
