using FIAP.CP2.Data;
using FIAP.CP2.Infra.Repositories;
using FIAP.CP2.Model.Interfaces;
using FIAP.CP2.Application.Interfaces;
using FIAP.CP2.Application.Services;
using FIAP.CP2.Domain.Interfaces;
using FIAP.CP2.Domain.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Connection + EF Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("DefaultPolicy", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Repos (Infra)
builder.Services.AddScoped<IProfissaoAntigaRepository, ProfissaoAntigaRepository>();
builder.Services.AddScoped<IProfissaoAtualRepository, ProfissaoAtualRepository>();
builder.Services.AddScoped<IProfissaoFuturaRepository, ProfissaoFuturaRepository>();

// Application Services
builder.Services.AddScoped<IProfissaoAntigaAppService, ProfissaoAntigaAppService>();
builder.Services.AddScoped<IProfissaoAtualAppService, ProfissaoAtualAppService>();
builder.Services.AddScoped<IProfissaoFuturaAppService, ProfissaoFuturaAppService>();

// Domain Services
builder.Services.AddScoped<IProfissaoAntigaDomainService, ProfissaoAntigaDomainService>();
builder.Services.AddScoped<IProfissaoAtualDomainService, ProfissaoAtualDomainService>();
builder.Services.AddScoped<IProfissaoFuturaDomainService, ProfissaoFuturaDomainService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("DefaultPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
