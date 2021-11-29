using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace Migracion.App.Frontend.Pages.Revaluar
{
    public class IndexModel : PageModel
    {
       private readonly IRepositorioEvaluar _repoEvaluar;
        public Evaluar evaluar {get;set;}
 
        //public IEnumerable < Migrantes > migrantes {get; set;}
        public IndexModel (IRepositorioEvaluar repoEvaluar)
        {
                _repoEvaluar = repoEvaluar;
        }
 
        public void OnGet()
        {
 
        }
 
        public IActionResult OnPost(Evaluar evaluar)
        {
            Console.WriteLine(evaluar.Evaluacion);
 
            if (ModelState.IsValid)
            {
                _repoEvaluar.AddEvaluar(evaluar);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
           
        }
    }

}
