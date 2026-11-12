using PairProgrammingBackEnd;
using PairProgrammingBackEnd.Repositories;
var builder = WebApplication.CreateBuilder(args);



//Cors implementation
const string AllowedPolicy = "AllowAll";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowedPolicy, policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<IRecordRepository>(new RecordRepository());

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors(AllowedPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
