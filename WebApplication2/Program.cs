using WebApplication2.ServicesLayer;
using WebApplication2.DALLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILogicService, LogicService>();
builder.Services.AddScoped<IUserAnswersRepository, UserAnswersRepository>();
builder.Services.AddScoped<IRightAnswersRepository, RightAnswersRepository>();
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=123"));

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
