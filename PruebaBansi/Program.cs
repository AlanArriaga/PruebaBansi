using PruebaBansi.Data;

var builder = WebApplication.CreateBuilder(args);

// Obtiene la cadena de conexión de la configuración.
var connString = builder.Configuration.GetConnectionString("BdiExamen");
// Añade el contexto de la base de datos.
builder.Services.AddSqlServer<ExamenContext>(connString);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Examen}/{action=Lista}/{id?}");

//Crea la base de datos si no existe.
await app.MigrateDbAsync();

app.Run();
