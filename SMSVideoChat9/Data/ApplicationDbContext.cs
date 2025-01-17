using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace SMSVideoChat9.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<SystemCredentials> SystemCredentials { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ChatThread> ChatThreads { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
    }
}
