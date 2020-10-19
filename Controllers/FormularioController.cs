using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaLabo01.Models;

namespace PracticaLabo01.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }
        public IActionResult Formulario()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Formulario( Formulario objFormulario){
         if(ModelState.IsValid)
         {
             //grabar
             objFormulario.Respuesta="Se registraron sus datos en la Base de Datos.";
         }
         return View("Formulario",objFormulario);
        }

    }
}

