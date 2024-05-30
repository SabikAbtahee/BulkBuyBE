using BulkBuy.Identity.Extensions;
using BulkBuy.ProductFeature.Extensions;
using BulkBuy.Web.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;
using BulkBuy.Repository;

var builder = WebApplication.CreateBuilder(args);

LogManager.Setup().LoadConfiguration(builder =>
{
    builder.ForLogger().FilterMinLevel(NLog.LogLevel.Info).WriteToConsole();
    builder.ForLogger().FilterMinLevel(NLog.LogLevel.Debug).WriteToFile(fileName: "file.txt");
});

//Services
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();


builder.Services
    .ConfigureMongoDatabase()
    .ConfigureMongoRepository();

builder.Services.AddIdentityCollection();
builder.Services.AddProductCollection();

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
