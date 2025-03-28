using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Reservation.Review.Context;
using Reservation.Review.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ReviewContext>(opt =>
{
    opt.UseNpgsql(connectionString);
});

builder.Services.AddScoped<IUserReviewService, UserReviewService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
