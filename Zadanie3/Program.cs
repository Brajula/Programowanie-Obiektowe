namespace Zadanie3
{
    class Program
    {
        static void Main()
        {
            var kolo = new Kolo(5);
            Console.WriteLine($"Kolo: Promien={kolo.Promien}, Pole={kolo.Pole:F2}, Obwod={kolo.Obwod:F2}, Srednica={kolo.Srednica:F2}");

            var prostokat = new Prostokat(4, 3, 45);
            Console.WriteLine(prostokat);

            var deltoid = new Deltoid(3, 5, 6, 4, 60, 120, 15);
            Console.WriteLine(deltoid);
        }
    }

}
