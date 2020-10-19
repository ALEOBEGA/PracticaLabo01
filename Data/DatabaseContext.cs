using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PracticaLabo01.Data
{
    public class DatabaseContext : DbContext
    {
         public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
          {
          }
     public DbSet<PracticaLabo01.Models.Formulario> Formularios { get; set; }
    }
}