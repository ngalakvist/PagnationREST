using Microsoft.EntityFrameworkCore;
using Pagination.WebApi.Models;

namespace Pagination.WebApi.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}