using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class JLTechContext : DbContext
    {
        public JLTechContext(DbContextOptions<JLTechContext> options) : base(options)
        {
            
        }

        public DbSet<Ticket> Ticket { get; set; }
    }
}
