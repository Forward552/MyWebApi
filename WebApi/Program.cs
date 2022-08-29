using Domain.Interfaces;
using Infrastracter.Data;
using Infrastracter.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//AddScoped przy ka¿dym zapytyaniu tworzone jest nowa istancja klasy repository
builder.Services.AddScoped<INoteRepository, NoteRepository>();
builder.Services.AddDbContext<MyNotesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyNotesCS")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
