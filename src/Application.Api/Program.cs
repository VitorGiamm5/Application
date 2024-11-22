using System.Text.JsonSerialization;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreationBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddEndPointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
c.SwaggerDoc("v1", new OpenApiInfo {
    Title: "API Core Products",
    Version: "v1"
}))

builder.Configuration
    .SetBasepath(Directory.GetCurrentDirectory())

builder.Services.AddApplication(builder.Configuration);

var app = builder.Build();

app.MapControllers().WithMetadata(new RouteAttribute("api"));

app.Run();