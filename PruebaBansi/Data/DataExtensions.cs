using Microsoft.EntityFrameworkCore;

namespace PruebaBansi.Data;

public static class DataExtensions
{
    //Asegura de que todas las migraciones faltantes de la base de datos se apliquen cuando se inicia la aplicación
    //garantizando que la base de datos esté siempre actualizada.
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ExamenContext>();
        await dbContext.Database.MigrateAsync();
    }
}
