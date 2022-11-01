using Microsoft.EntityFrameworkCore;
using TEST1.API.Models.Domain;

namespace TEST1.API.Data
{
    public class TEST1DBContext:DbContext
    {
        public TEST1DBContext(DbContextOptions<TEST1DBContext> options):base(options)
        {

        }

        public DbSet<college> Colleges { get; set; }
        public DbSet<student> students { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
