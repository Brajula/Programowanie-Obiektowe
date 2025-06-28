using System;

namespace Zadanie3
{
    public class Deltoid : Figura
    {
        private double a;
        private double b;
        private double d1;
        private double d2;
        private double orientacja;
        private double katAlpha;
        private double katBeta;

        public double A
        {
            get => a;
            set
            {
                if (value <= 0) throw new ArgumentException("Bok A musi byc dodatni.");
                a = value;
            }
        }

        public double B
        {
            get => b;
            set
            {
                if (value <= 0) throw new ArgumentException("Bok B musi byc dodatni.");
                b = value;
            }
        }

        public double PrzekatnaDluga
        {
            get => d1;
            set
            {
                if (value <= 0) throw new ArgumentException("Przekatna musi byc dodatnia.");
                d1 = value;
            }
        }

        public double PrzekatnaKrotka
        {
            get => d2;
            set
            {
                if (value <= 0) throw new ArgumentException("Przekatna musi byc dodatnia.");
                d2 = value;
            }
        }

        public double KatAlpha
        {
            get => katAlpha;
            set
            {
                if (value <= 0 || value >= 180) throw new ArgumentException("Kat musi byc w zakresie (0,180).");
                katAlpha = value;
            }
        }

        public double KatBeta
        {
            get => katBeta;
            set
            {
                if (value <= 0 || value >= 180) throw new ArgumentException("Kat musi byc w zakresie (0,180).");
                katBeta = value;
            }
        }

        public double Orientacja
        {
            get => orientacja;
            set
            {
                if (value < 0 || value >= 360) throw new ArgumentException("Orientacja musi byc w zakresie [0, 360).");
                orientacja = value;
            }
        }

        public Deltoid(double a, double b, double d1, double d2, double katAlpha, double katBeta, double orientacja = 0)
        {
            A = a;
            B = b;
            PrzekatnaDluga = d1;
            PrzekatnaKrotka = d2;
            KatAlpha = katAlpha;
            KatBeta = katBeta;
            Orientacja = orientacja;
        }

        public override double Pole => 0.5 * d1 * d2;
        public override double Obwod => 2 * (a + b);
        public override double Srednica => Math.Max(d1, d2);

        public override string ToString()
        {
            return $"Deltoid: A={A}, B={B}, Dluga={PrzekatnaDluga}, Krotka={PrzekatnaKrotka}, Alpha={KatAlpha}, Beta={KatBeta}, Orientacja={Orientacja}, Pole={Pole:F2}, Obwod={Obwod:F2}";
        }
    }
}
