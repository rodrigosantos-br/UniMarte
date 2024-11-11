using Microsoft.EntityFrameworkCore;
using UniMarte.Web.Data;
using UniMarte.Web.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurar o banco de dados usando a string de conexão no appsettings.json
builder.Services.AddDbContext<ConnectionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionar repositórios e serviços à injeção de dependência
builder.Services.AddScoped<IVisitanteRepository, VisitanteRepository>();
builder.Services.AddScoped<IObraRepository, ObraRepository>();
builder.Services.AddControllersWithViews();

// Agora que todos os serviços foram configurados, construímos o aplicativo
var app = builder.Build();

// Configurar o pipeline de requisição HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configurar a rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
