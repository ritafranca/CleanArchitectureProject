using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


// Adicionando serviços ao container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // ✅ Adiciona o Swagger

builder.Services.AddSingleton<IApplicationDbContext, ApplicationDbContext>();

var app = builder.Build();

// Configurar Swagger corretamente
if (app.Environment.IsDevelopment() || app.Environment.IsProduction()) // ✅ Garante que funcione em produção
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>  
    {  
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");  
        c.RoutePrefix = "swagger"; // Define a URL correta do Swagger
    });  
}

app.MapGet("/", () => Results.Redirect("/swagger"));
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
public partial class Program { }
