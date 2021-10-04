
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
namespace ProyectoCiclo3.App.Frontend.Pages
    {
        public class CreateAvionModel : PageModel
        {
            private readonly RepositorioAviones repositorioAviones;
            [BindProperty]
            public Aviones Avion {get;set;}
            
            public CreateAvionModel(RepositorioAviones repositorioAviones)
        {
             this.repositorioAviones=repositorioAviones;
        }
          public IActionResult OnGet(int avionId)
        {
            Avion=repositorioAviones.GetAvionWithId(avionId);
            return Page(); 
        }
           public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }     

            Avion = repositorioAviones.Create(Avion);            
            return RedirectToPage("./List");
        }
    }
 }


        
