using Microsoft.EntityFrameworkCore;

namespace PruebaBansi.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ExamenContext>();
        await dbContext.Database.MigrateAsync();
    }
}
