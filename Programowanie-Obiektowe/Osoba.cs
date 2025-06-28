namespace Zadanie1
{
    public class Osoba
    {
        private string _imię;
        public string Nazwisko { get; set; }
        public DateTime? DataUrodzenia { get; set; } = null;
        public DateTime? DataŚmierci { get; set; } = null;

        public Osoba(string imięNazwisko) => ImięNazwisko = imięNazwisko;


        public string Imię
        {
            get => _imię;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Imię nie może być puste.");
                _imię = value;
            }
        }
        public string ImięNazwisko
        {
            get => $"{Imię} {Nazwisko}".Trim();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Imię i nazwisko nie mogą być puste.");

                string[] parts = value.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Imię = parts[0];
                Nazwisko = parts.Length > 1 ? parts[^1] : "";
            }
        }

        public TimeSpan? Wiek
        {
            get
            {
                if (DataUrodzenia == null)
                    return null;

                DateTime koniec = DataŚmierci ?? DateTime.Now;
                return koniec - DataUrodzenia;
            }
        }
    }
}
