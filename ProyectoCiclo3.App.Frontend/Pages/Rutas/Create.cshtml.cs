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
    public class FormRutaModel : PageModel
    {

        private readonly RepositorioEstaciones repositorioEstaciones;
        public IEnumerable<Estaciones> Estaciones {get;set;}

        private readonly RepositorioRutas repositorioRutas;
        [BindProperty]
        public Rutas Ruta {get;set;}

        public FormRutaModel(RepositorioRutas repositorioRutas, RepositorioEstaciones repositorioEstaciones)
       {
            this.repositorioRutas=repositorioRutas;
            this.repositorioEstaciones=repositorioEstaciones;
       }

        public void OnGet()
        {
            Estaciones=repositorioEstaciones.GetAll();
        }

        public IActionResult OnPost(int origen, int destino, int tiempo_estimado)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }else{            
                repositorioRutas.Create(origen, destino, tiempo_estimado);            
                return RedirectToPage("./List");
            }
        }
    }
}