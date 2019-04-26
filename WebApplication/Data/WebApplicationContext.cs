using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class WebApplicationContext : DbContext
    {
        public WebApplicationContext (DbContextOptions<WebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }

        public DbSet<DocumentType> DocumentType { get; set; }

        public DbSet<Document> Document { get; set; }

        public DbSet<User> User { get; set; }
    }
}
