using BulkBuy.CommandsHandler.Extensions;
using BulkBuy.Web.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;
var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));

//Services
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();

builder.Services.AddCommandsHandlerCollection();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

//Pipeline - order here matters 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.All });
app.UseCors("CorsPolicy");
app.UseAuthorization();


app.MapControllers();

app.Run();
