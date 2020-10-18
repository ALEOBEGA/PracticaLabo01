using System;
using System.ComponentModel.DataAnnotations;

namespace PracticaLabo01.Models
{
    public class Formulario 
    {
        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Nombre")]  
        public string Nombre { get; set; }
        
        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Apellido")]
        public string Apellido { get; set; }
        
        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Distrito")]
        public String Distrito { get; set; }

        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Bancos")]
        public string Bancos { get; set; }

        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Edad")]
        public string Edad { get; set; }
        public string Genero { get; set; }

        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Autor")]
        public string Autor { get; set; }

        [Display(Name="Output")] 
         public string Respuesta { get; set; }

    }
}
