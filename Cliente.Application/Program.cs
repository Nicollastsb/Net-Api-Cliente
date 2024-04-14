using Cliente.Domain.Interfaces;
using Cliente.CrossCutting;
using Cliente.Infra.Data.Context;
using Cliente.Infra.Data.Repository;
using Cliente.Service;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<SqlServerContext>(db => 
    db.UseSqlServer(builder.Configuration.GetConnectionString("ClienteConnectionString")), ServiceLifetime.Singleton);
builder.Services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

builder.Services.AddControllers();

var assemblies = Assembly.Load("Cliente.CrossCutting");
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assemblies));

builder.Services.AddAutoMapper(typeof(ClientProfile));
builder.Services.AddCors(option => option.AddDefaultPolicy(policy => {
    policy.AllowAnyOrigin();
    policy.AllowAnyMethod();
    policy.AllowAnyHeader();
}));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.Services.CreateScope().ServiceProvider.GetRequiredService<SqlServerContext>().Database.EnsureCreated();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
