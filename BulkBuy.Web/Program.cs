using BulkBuy.Api;
using BulkBuy.Application;
using BulkBuy.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
       .AddPresentation()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
}

//LogManager.Setup().LoadConfiguration(builder =>
//{
//    builder.ForLogger().FilterMinLevel(NLog.LogLevel.Info).WriteToConsole();
//    builder.ForLogger().FilterMinLevel(NLog.LogLevel.Debug).WriteToFile(fileName: "file.txt");
//});
////Services

//builder.Services.ConfigureCors();
//builder.Services.ConfigureIISIntegration();
//builder.Services.ConfigureLoggerService();


//builder.Services
//    .ConfigureMongoDatabase()
//    .ConfigureMongoRepository();

//builder.Services.AddIdentityCollection();
//builder.Services.AddProductCollection();

//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}

//PipeLineOrder
//ExceptionHandler
//HSTS
//Httpsredirect
//StaticFoles
//Routing
//Cors
//Authentication
//Authorization
//Customs
//Endpoint

//app.UseExceptionHandler("/Error");

//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//}
//else
//    app.UseHsts();



//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseCors("CorsPolicy");
////app.UseAuthentication();
////app.UseAuthorization();
////app.UseSession();

//app.MapControllers();

//app.Run();
