using AppRazorApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AppRazorApplication.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> contacts { get; set; }
    }
}
