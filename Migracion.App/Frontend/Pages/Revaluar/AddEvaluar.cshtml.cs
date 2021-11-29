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
    public class AddEvaluarModel : PageModel
    {
        private readonly IRepositorioEvaluar _repoEvaluar;
        public Evaluar evaluar {get;set;}
        public AddEvaluarModel(IRepositorioEvaluar repoEvaluar)
        {
            _repoEvaluar = repoEvaluar;
        }
        public void OnGet()
        {
            evaluar = new Evaluar();
        }

        public IActionResult OnPost(Evaluar evaluar)
        {
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
