using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>option):base(option)
        {
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
