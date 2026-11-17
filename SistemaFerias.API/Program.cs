using Microsoft.EntityFrameworkCore;
using SistemaFerias.API.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionstring = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionstring));

builder.Services.AddControllers();

// LIBERAÇÃO TOTAL DE CORS (Ideal para testes locais)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ATIVE O CORS ANTES DOS CONTROLADORES E DA AUTORIZAÇÃO
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();