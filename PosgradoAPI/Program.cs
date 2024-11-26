using Microsoft.EntityFrameworkCore;
using PosgradoAPI.BusinessLayer.DependencyInjection;
using PosgradoAPI.DataBaseContext;
using PosgradoAPI.DataLayer.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddLogging();
// Add services to the container.
builder.Services.AddDataLayerDependencies();
builder.Services.AddBusinessLayerDependencies();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Agrega servicios al DbContext.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgradoDb")));


builder.Services.AddControllers();
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

