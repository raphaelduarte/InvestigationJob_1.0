using InvestigationJob.API.Entities.Interface;
using Microsoft.EntityFrameworkCore;

namespace InvestigationJob.API.Context;

public class ApiDbContext : DbContext
{
    protected ApiDbContext()
    {
    }

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        public DbSet<ITelefone>? Usuarios { get; set; }
        public DbSet<ITelefone>? Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
} 
}