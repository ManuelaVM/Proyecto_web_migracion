using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class RegistroMigranteModel : PageModel
    {
        private readonly IRepositorioMigrantes _repoMigrante;
        public Migrante migrantes {get;set;}
        public RegistroMigranteModel(IRepositorioMigrantes repoMigrantes)
        {
            _repoMigrante = repoMigrantes;
        }

     
        public void OnGet()
        {
            migrantes = new Migrante();
        }

        public IActionResult OnPost(Migrante migrante)
        {
            if (ModelState.IsValid)
            {
                _repoMigrante.AddMigrantes(migrante);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
            
        }
    }
}
