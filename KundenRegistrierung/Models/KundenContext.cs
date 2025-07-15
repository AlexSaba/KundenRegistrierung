using Microsoft.EntityFrameworkCore;
using KundenRegistrierung;
using KundenRegistrierung.DatenbankModell;

public class KundenContext : DbContext
{
    public KundenContext(DbContextOptions<KundenContext> options) : base(options) { }

    public DbSet<Kunde> Kunden { get; set; }
}