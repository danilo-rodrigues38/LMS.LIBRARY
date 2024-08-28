using LMS.LIBRARY.API.Context;
using LMS.LIBRARY.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers ( );
builder.Services.AddEndpointsApiExplorer ( );
builder.Services.AddSwaggerGen ( );
builder.Services.AddDbContext<LibraryDbContext> ( options => options.UseSqlServer ( builder.Configuration.GetConnectionString ( "DefaultConnection" ) ) );
builder.Services.AddScoped<IBookService, BookService> ( );

var app = builder.Build();

if (app.Environment.IsDevelopment ( ))
{
    app.UseSwagger ( );
    app.UseSwaggerUI ( );
}

app.UseHttpsRedirection ( );

app.UseAuthorization ( );

app.MapControllers ( );

app.Run ( );
