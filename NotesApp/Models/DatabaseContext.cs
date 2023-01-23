using Microsoft.EntityFrameworkCore;

namespace NotesApp.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
    }
}
