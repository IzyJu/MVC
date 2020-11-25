using Microsoft.EntityFrameworkCore;
using ExMvc.Models;

namespace ExMvc.Data
{
    public class ExMvcContext : DbContext
    {
        public ExMvcContext(DbContextOptions<ExMvcContext> options)
            : base(options)
        {
        }
        public DbSet<Articles> Articles { get; set; }
    }
}