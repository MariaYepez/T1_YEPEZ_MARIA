using Microsoft.EntityFrameworkCore;
using T1_YEPEZ_MARIA.Models;
namespace T1_YEPEZ_MARIA.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}