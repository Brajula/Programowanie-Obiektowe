namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj imię i nazwisko: ");
                string imięNazwisko = Console.ReadLine();

                Osoba osoba = new Osoba(imięNazwisko);

                Console.Write("Podaj datę urodzenia (RRRR-MM-DD): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dataUr))
                    osoba.DataUrodzenia = dataUr;
                else
                    Console.WriteLine("Niepoprawny format daty urodzenia – zostanie pominięta.");

                Console.Write("Czy chcesz podać datę śmierci? (T/N): ");

                string decyzja = Console.ReadLine().Trim().ToUpper();


                if (decyzja == "T")
                {
                    Console.Write("Podaj datę śmierci (RRRR-MM-DD): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime dataSm))
                        osoba.DataŚmierci = dataSm;
                    else
                        Console.WriteLine("Niepoprawny format daty śmierci – zostanie pominięta.");
                }


                Console.WriteLine("\nDane osoby:");
                Console.WriteLine($"Imię: {osoba.Imię}");
                Console.WriteLine($"Nazwisko: {osoba.Nazwisko}");
                Console.WriteLine($"Imię i nazwisko: {osoba.ImięNazwisko}");
                Console.WriteLine($"Data urodzenia: {osoba.DataUrodzenia?.ToString("yyyy-MM-dd") ?? "brak"}");
                Console.WriteLine($"Data śmierci: {osoba.DataŚmierci?.ToString("yyyy-MM-dd") ?? "żyje"}");


                if (osoba.Wiek.HasValue)
                {
                    var lata = Math.Floor(osoba.Wiek.Value.TotalDays / 365.25);
                    Console.WriteLine($"Wiek: {lata} lat");
                }
                else
                    Console.WriteLine("Wiek: brak danych");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n Błąd: " + ex.Message);
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
