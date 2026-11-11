using PairProgrammingBackEnd;
using PairProgrammingBackEnd.Repositories;
using Microsoft.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

//Swagger Implementation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddOpenApi();

builder.Services.AddSingleton<IRecordRepostory>(new RecordRepostory());

var app = builder.Build();

//Cors implementation
const string AllowedPolicy = "AllowAll";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowedPolicy, policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(AllowedPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
