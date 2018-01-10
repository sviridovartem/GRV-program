using System;

namespace Diplom.Models
{
    public class Sector
    {
        public string Name { get; set; }
        public double Angl1 { get; set; }
        public double Angl2 { get; set; }

        public double Angl1Rad
        {
            get { return ToRad(Angl1); }
        }

        public double Angl2Rad
        {
            get { return ToRad(Angl2); }
        }

        private static double ToRad(double angle)
        {
            return (Math.PI / 180) * (angle - 90);
        }
    }
}
