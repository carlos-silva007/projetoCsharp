using Microsoft.EntityFrameworkCore;

using ProjetoContaApi.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ContaContext>(opt => opt.UseMySql(

builder.Configuration.GetConnectionString("mysqlConnection"),
 new MySqlServerVersion(new Version())
));
// Learn more about configuring Swagger/OpenAPI at 


builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // app.UseSwagger();
    // app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
