using System.Numerics;

namespace Zadanie2{

    class Program
    {
        static void Main(string[] args)
        {
            Wektor v1 = new Wektor(1, 2, 3);
            Wektor v2 = new Wektor(4, 5, 6);

            Console.WriteLine($"v1: {v1}");
            Console.WriteLine($"v2: {v2}");

            Console.WriteLine($"v1 + v2: {v1 + v2}");
            Console.WriteLine($"v1 - v2: {v1 - v2}");
            Console.WriteLine($"2 * v1: {2 * v1}");
            Console.WriteLine($"v2 / 2: {v2 / 2}");
            Console.WriteLine($"Długość v1: {v1.Długość}");
            Console.WriteLine($"Iloczyn skalarny: {Wektor.IloczynSkalarny(v1, v2)}");

            var suma = Wektor.Suma(v1, v2, new Wektor(1, 1, 1));
            Console.WriteLine($"Suma trzech wektorów: {suma}");
        }
    }


}
