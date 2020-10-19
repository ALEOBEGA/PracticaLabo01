using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaLabo01.Models;
using PracticaLabo01.Data;

namespace PracticaLabo01.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        private readonly DatabaseContext _context;

        public FormularioController(ILogger<FormularioController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
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
             _context.Add(objFormulario);
             _context.SaveChanges();
             
             objFormulario.Respuesta="Se registraron sus datos en la Base de Datos.";
         }
         return View("Formulario",objFormulario);
        }

    }
}

