using Layer.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

//TODO: INSTALL SWAGGER, OPENAPI

// builder.Services.AddOpenApi();
// builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder
    .AddApplicationServices()
    .AddIntegrationServices()
    .AddRepositories()
    .AddMiddlewares()
    .AddDbContext();

var app = builder.Build();

app.InitializeDataBase();

if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    // app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.UseHttpsRedirection();

app.Run();