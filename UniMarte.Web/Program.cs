using Microsoft.EntityFrameworkCore;
using UniMarte.Web.Data;
using UniMarte.Web.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurar o banco de dados usando a string de conex�o no appsettings.json
builder.Services.AddDbContext<ConnectionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionar reposit�rios e servi�os � inje��o de depend�ncia
builder.Services.AddScoped<IVisitanteRepository, VisitanteRepository>();
builder.Services.AddScoped<IObraRepository, ObraRepository>();
builder.Services.AddControllersWithViews();

// Agora que todos os servi�os foram configurados, constru�mos o aplicativo
var app = builder.Build();

// Configurar o pipeline de requisi��o HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configurar a rota padr�o
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
