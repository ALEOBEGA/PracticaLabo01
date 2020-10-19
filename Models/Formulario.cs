using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PracticaLabo01.Models
{
    [Table("t_formulario")]
    public class Formulario 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Column("id")]  
        public int ID { get; set; }

        [Required(ErrorMessage="Por favor ingrese Datos")] 
        [Display(Name="Nombre")]  
        [Column("nombre")] 
        public string Nombre { get; set; }
        
        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Apellido")]
        [Column("apellido")] 
        public string Apellido { get; set; }
        
        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Distrito")]
        [Column("distrito")] 
        public String Distrito { get; set; }

        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Bancos")]
        [Column("banco")] 
        public string Bancos { get; set; }

        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Edad")]
        [Column("edad")] 
        public string Edad { get; set; }

        [Required(ErrorMessage="Por favor seleccione el Dato")]  
        [Display(Name="Genero")]
        [Column("genero")] 
        public string Genero { get; set; }

        [Required(ErrorMessage="Por favor ingrese Datos")]  
        [Display(Name="Autor")]
        [Column("autor")] 
        public string Autor { get; set; }

      
        [NotMapped]
         public string Respuesta { get; set; }

    }
}
