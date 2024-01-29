using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.EnableAnnotations();
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "EventMaster Web API",
            Description = "API to manager events",
            Contact = new OpenApiContact() { Name = "John Smith", Email = "jsmith@mayl.com" },
            License = new OpenApiLicense() { Name = "MIT License", Url = new Uri("https://opensource.org/licenses/MIT") }
        });
        c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "EventMasterSwaggerAnnotation.xml"));
    }
);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();
app.Run();