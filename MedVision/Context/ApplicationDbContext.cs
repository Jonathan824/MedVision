using MedVision.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedVision.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Cita> Cita { get; set; }
        public DbSet<MotivoCita> MotivoCita { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
