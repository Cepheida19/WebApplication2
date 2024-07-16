using WebApplication2.DataBase;
using WebApplication2.ServicesLayer;
using WebApplication2.DALLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IQuestionAnswerSave, QuestionAnswerSave>();
builder.Services.AddSingleton<IQuestionAnswerRight, QuestionAnswerRight>();
builder.Services.AddTransient<ILogicService, LogicService>();
builder.Services.AddTransient<IDataService, DataService>();
builder.Services.AddScoped<IUserAnswersRepository, UserAnswersRepository>();
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
