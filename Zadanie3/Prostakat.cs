using System;

namespace Zadanie3
{
    public class Prostokat : Figura
    {
        private double a;
        private double b;
        private double orientacja;

        public double A
        {
            get => a;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Bok A musi byc dodatni.");
                a = value;
            }
        }

        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Bok B musi byc dodatni.");
                b = value;
            }
        }

        public double Orientacja
        {
            get => orientacja;
            set
            {
                if (value < 0 || value >= 360)
                    throw new ArgumentException("Orientacja musi byc w zakresie [0, 360).");
                orientacja = value;
            }
        }

        public double Kat => 90;

        public Prostokat(double a, double b, double orientacja = 0)
        {
            A = a;
            B = b;
            Orientacja = orientacja;
        }

        public override double Pole => a * b;
        public override double Obwod => 2 * (a + b);
        public override double Srednica => Math.Sqrt(a * a + b * b);

        public override string ToString()
        {
            return $"Prostokat: A={A}, B={B}, Orientacja={Orientacja}, Pole={Pole:F2}, Obwod={Obwod:F2}, Srednica={Srednica:F2}";
        }
    }
}
