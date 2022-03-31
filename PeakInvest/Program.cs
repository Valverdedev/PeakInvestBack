using PeakInvest.Interfaces;
using PeakInvest.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddScoped<ICalculoService, CalculoService>();
builder.Services.AddScoped<IPessoaService, PessoaService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}


app.UseHttpsRedirection();
app.UseCors(options => options.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();

app.Run();
