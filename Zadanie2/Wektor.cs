namespace Zadanie2
{
    public class Wektor
    {
        private readonly double[] współrzędne;

        public Wektor(byte wymiar)
        {
            if (wymiar == 0)
                throw new ArgumentException("Wymiar nie może być zerowy.");

            współrzędne = new double[wymiar];
        }

        public Wektor(params double[] współrzędne)
        {
            if (współrzędne == null || współrzędne.Length == 0)
                throw new ArgumentException("Wektor musi mieć co najmniej jeden wymiar.");

            this.współrzędne = (double[])współrzędne.Clone();
        }

        public byte Wymiar => (byte)współrzędne.Length;

        public double Długość => Math.Sqrt(IloczynSkalarny(this, this));

        public double this[byte i]
        {
            get
            {
                if (i >= Wymiar)
                    throw new IndexOutOfRangeException();
                return współrzędne[i];
            }
            set
            {
                if (i >= Wymiar)
                    throw new IndexOutOfRangeException();
                współrzędne[i] = value;
            }
        }

        public static double IloczynSkalarny(Wektor v, Wektor w)
        {
            if (v.Wymiar != w.Wymiar)
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

            double suma = 0;
            for (byte i = 0; i < v.Wymiar; i++)
                suma += v[i] * w[i];

            return suma;
        }

        public static Wektor Suma(params Wektor[] wektory)
        {
            if (wektory == null || wektory.Length == 0)
                throw new ArgumentException("Brak wektorów do zsumowania.");

            byte wymiar = wektory[0].Wymiar;
            if (wektory.Any(w => w.Wymiar != wymiar))
                throw new ArgumentException("Wszystkie wektory muszą mieć ten sam wymiar.");

            double[] suma = new double[wymiar];
            foreach (var w in wektory)
            {
                for (byte i = 0; i < wymiar; i++)
                    suma[i] += w[i];
            }

            return new Wektor(suma);
        }

        public static Wektor operator +(Wektor a, Wektor b)
        {
            if (a.Wymiar != b.Wymiar)
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

            double[] wynik = new double[a.Wymiar];
            for (byte i = 0; i < a.Wymiar; i++)
                wynik[i] = a[i] + b[i];

            return new Wektor(wynik);
        }

        public static Wektor operator -(Wektor a, Wektor b)
        {
            if (a.Wymiar != b.Wymiar)
                throw new ArgumentException("Wektory muszą mieć ten sam wymiar.");

            double[] wynik = new double[a.Wymiar];
            for (byte i = 0; i < a.Wymiar; i++)
                wynik[i] = a[i] - b[i];

            return new Wektor(wynik);
        }

        public static Wektor operator *(Wektor w, double skalar)
        {
            double[] wynik = new double[w.Wymiar];
            for (byte i = 0; i < w.Wymiar; i++)
                wynik[i] = w[i] * skalar;

            return new Wektor(wynik);
        }

        public static Wektor operator *(double skalar, Wektor w) => w * skalar;

        public static Wektor operator /(Wektor w, double skalar)
        {
            if (skalar == 0)
                throw new DivideByZeroException("Nie można dzielić przez zero.");

            double[] wynik = new double[w.Wymiar];
            for (byte i = 0; i < w.Wymiar; i++)
                wynik[i] = w[i] / skalar;

            return new Wektor(wynik);
        }
    }
}
