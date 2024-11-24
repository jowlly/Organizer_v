using Microsoft.EntityFrameworkCore;


namespace Organizer_v.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
            
        }

        public DbSet<Contact> Contacts => Set<Contact>();

        public DbSet<Event> Events => Set<Event>();
    }
}
