using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.Migrantes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMigrantes _repoMigrantes;
        public Migrante migrante {get;set;}

        //public IEnumerable < Migrantes > migrantes {get; set;}
        public IndexModel (IRepositorioMigrantes repoMigrantes)
        {
                _repoMigrantes = repoMigrantes;
        }
        public void OnGet()
        {
            //migrante = _repoMigrantes.GetMigrante();
        }

        public IActionResult OnPost(Migrante migrante)
        {
            Console.WriteLine(migrante.Nombre);
            Console.WriteLine(migrante.Apellidos);
            Console.WriteLine(migrante.Tipo_identificacion);
            Console.WriteLine(migrante.Numero_identificacion);
            Console.WriteLine(migrante.Pais_origen);
            Console.WriteLine(migrante.Fecha_nacimiento);
            Console.WriteLine(migrante.Direccion_electronica);
            Console.WriteLine(migrante.Ciudad);
            Console.WriteLine(migrante.Situacion_laboral);

            if (ModelState.IsValid)
            {
                _repoMigrantes.AddMigrantes(migrante);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
            
        }
    }
}
