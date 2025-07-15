using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Emit;

namespace KundenRegistrierung.Pages
{
    public class FormularModel : PageModel
    {
        public string? VorName
        {
            get => VorName;
            set
            {
                VorName = value;
            }
        }
        
        public string? NachName
        {
            get => NachName;
            set
            {
               NachName = value;
            }
        }

        public string? Email
        {
            get => Email;
            set
            {
                Email = value;
            }
        }

        public string? Telefon
        {
            get => Telefon;
            set
            {
                Telefon = value;
            }
        }

        public string? Passwort
        {
            get => Passwort;
            set
            {
                Passwort = value;
            }
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // Die Properties VorName, NachName, Email, Telefon, Passwort
            // sind jetzt mit den Formulardaten befüllt
        }
    }
}
