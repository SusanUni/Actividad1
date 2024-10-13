using mvcActividad1.Models;
using Microsoft.EntityFrameworkCore;

namespace mvcActividad1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        public DbSet<Productos> Productos { get; set; }
    }


}
