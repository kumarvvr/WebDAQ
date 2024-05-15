using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using WebDAQCore.Models;
using Npgsql;
using Microsoft.Extensions.Configuration;


namespace WebDAQCore.Infrastructure.Database;

public class PGSQLContext : DbContext
{
    private IConfiguration configuration;
    public DbSet<Plant> Plants { get; set; }

    public PGSQLContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string? connectionstring = configuration["ConnectionStrings:PGSQL"];
        optionsBuilder.UseNpgsql(
            connectionstring);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Plant>().ToTable("t_plants");
    }
}