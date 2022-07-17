using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Database
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> opt) : base(opt)
        {
        }

        public DbSet<Project> Projects { get; set; }
    }
}
