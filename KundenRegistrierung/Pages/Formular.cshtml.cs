using KundenRegistrierung.DatenbankModell;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Emit;

namespace KundenRegistrierung.Pages
{
    public class FormularModel : PageModel
    {
        private readonly KundenContext? _context;

        [BindProperty]
        public string? VorName
        {
            get => VorName;
            set
            {
                VorName = value;
            }
        }
        [BindProperty]
        public string? NachName
        {
            get => NachName;
            set
            {
               NachName = value;
            }
        }
        [BindProperty]
        public string? Email
        {
            get => Email;
            set
            {
                Email = value;
            }
        }
        [BindProperty]
        public string? Telefon
        {
            get => Telefon;
            set
            {
                Telefon = value;
            }
        }
        [BindProperty]
        public string? Passwort
        {
            get => Passwort;
            set
            {
                Passwort = value;
            }
        }

        public FormularModel(KundenContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var kunde = new Kunde
            {
                VorName = VorName,
                NachName = NachName,
                Email = Email,
                Telefon = Telefon,
                Passwort = Passwort
            };

            _context?.Kunden.Add(kunde);
            _context?.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
