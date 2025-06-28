using System;

namespace Zadanie3
{
    public class Kolo : Figura
    {
        private double promien;

        public double Promien
        {
            get => promien;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Promien musi byc dodatni.");
                promien = value;
            }
        }

        public Kolo(double promien)
        {
            Promien = promien;
        }

        public override double Pole => Math.PI * promien * promien;
        public override double Obwod => 2 * Math.PI * promien;
        public override double Srednica => 2 * promien;
    }
}
