using Microsoft.EntityFrameworkCore;
using inventariosmvc.Models;

namespace inventariosmvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Servicio> Servicios { get; set; }
    }
}
