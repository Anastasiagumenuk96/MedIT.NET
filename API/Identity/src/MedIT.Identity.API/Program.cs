using MedIT.Identity.API;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddIdentityApi(builder.Configuration);

services.AddControllers();
services.AddSwaggerGen(x =>
    x.SwaggerDoc("v1", new OpenApiInfo { Title = "Identity", Version = "v1" }));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "Identity"));
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthorization();

app.Run();
