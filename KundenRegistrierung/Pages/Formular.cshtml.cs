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
        public string? Email { get; set; } = null;
        public int? Telefon { get; set; } = null;
        public string? Passwort { get; set; } = null;

        public void OnGet()
        {
        }
    }
}
