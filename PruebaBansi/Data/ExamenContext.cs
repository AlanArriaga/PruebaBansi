using PruebaBansi.Models;
using Microsoft.EntityFrameworkCore;
namespace PruebaBansi.Data;

public class ExamenContext(DbContextOptions<ExamenContext> options) : DbContext(options)
{
    public DbSet<Examen> tbIExamen => Set<Examen>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Examen>().HasKey(e => e.IdExamen);
    }

}
