using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");                        //The following code logs the request header "sec-ch-ua"
    logging.ResponseHeaders.Add("MyResponseHeader");                //The following code logs the response header "MyResponseHeader"
    logging.MediaTypeOptions.AddText("application/javascript");     //MediaTypeOptions provides configuration for selecting which encoding to use for a specific media type.
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;

});

services.AddControllers();

var app = builder.Build();

app.UseAuthorization();
app.UseHttpLogging();

app.Use(async (context, next) =>
{
    context.Response.Headers["MyResponseHeader"] =
        new string[] { "My Response Header Value" };

    await next();
});

app.MapControllers();
app.Run();
