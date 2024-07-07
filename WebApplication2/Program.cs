using WebApplication2.DataBase;
using WebApplication2.ServicesLayer;
using WebApplication2.DALLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IQuestionAnswerSave, QuestionAnswerSave>();
builder.Services.AddTransient<IQuestionAnswerRight, QuestionAnswerRight>();
builder.Services.AddTransient<ILogicService, LogicService>();
builder.Services.AddTransient<IDataService, DataService>();
builder.Services.AddTransient<ILogicCompareService, LogicCompareService>();
builder.Services.AddTransient<IDataServiceResult, DataServiceResult>();

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
