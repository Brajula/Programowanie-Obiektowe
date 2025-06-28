namespace Zadanie3
{
    public abstract class Figura
    {
        private (double x, double y) wspolrzedne;

        public (double x, double y) Wspolrzedne
        {
            get => wspolrzedne;
            set
            {
                if (double.IsNaN(value.x) || double.IsNaN(value.y))
                    throw new ArgumentException("Współrzędne muszą być liczbami.");
                wspolrzedne = value;
            }
        }

        public abstract double Pole { get; }
        public abstract double Obwod { get; }
        public abstract double Srednica { get; }
    }
}
