using Checkboxes2.Models;
using Microsoft.EntityFrameworkCore;

namespace Checkboxes2.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Person> People { get; set; }
    }
}