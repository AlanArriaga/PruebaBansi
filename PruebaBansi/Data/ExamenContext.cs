using PruebaBansi.Models;
using Microsoft.EntityFrameworkCore;
namespace PruebaBansi.Data;

public class ExamenContext(DbContextOptions<ExamenContext> options) : DbContext(options)
{
    // Esto permite realizar operaciones CRUD sobre la tabla 'tbIExamen'
    public DbSet<Examen> tbIExamen => Set<Examen>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configura la llave primaria 'IdExamen'
        modelBuilder.Entity<Examen>().HasKey(e => e.IdExamen);
    }

}
