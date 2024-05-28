using BulkBuy.Core.Entities;
using BulkBuy.Identity.Extensions;
using BulkBuy.Web.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

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
builder.Services.AddIdentityCollection();
builder.Services
    .ConfigureMongoDatabase()
    .ConfigureMongoRepository<Person>($"{nameof(Person)}s");
    //.ConfigureMongoRepository<Order>($"{nameof(Order)}s")
    //.ConfigureMongoRepository<Location>($"{nameof(Location)}s")
    //.ConfigureMongoRepository<OrderBatch>($"{nameof(OrderBatch)}s")
    //.ConfigureMongoRepository<Product>($"{nameof(Product)}s");
//builder.Services.ConfigureMongoRepositories("BulkBuy.Core.Entities");



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
