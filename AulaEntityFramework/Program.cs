using AulaEntityFramework.Models;
using AulaEntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration["AulaEntityFramework:ConnectionString"];

// Dependency Injection
//Fazemos a configuração do DbContext com 
// O banco de dados especifico, neste caso
// o SQLserver
builder.Services.AddDbContext<MyDbContext>(
        options => options.UseSqlServer(connString)
    );

// Registro dos serviços relacionados À camada de acesso ao repositorio de dados (repository)

builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//Ctrl + Shift + b = Compilar