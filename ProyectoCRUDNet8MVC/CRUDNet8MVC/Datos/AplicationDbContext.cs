using CRUDNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNet8MVC.Datos
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {   
        }
        //Agregar los modelos aqui (Cada modelo corresponde a una tabla en la BD)
        public DbSet<Contacto> Contacto { get; set; }
    }
}
