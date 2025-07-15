namespace KundenRegistrierung.DatenbankModell
{
    public class Kunde
    {
        public int Id { get; set; }
        public string? VorName { get; set; }
        public string? NachName { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? Passwort { get; set; }
    }
}
