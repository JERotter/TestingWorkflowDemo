using DemoTestApp;

var builder = WebApplication.CreateBuilder(args);

//for testing
ConfigureServices(builder.Services);

// Add services to the container.
builder.Services.AddScoped<MathFunctionsService, MathFunctionsService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/// <summary>
/// For testing
/// https://www.youtube.com/watch?v=ULJ3UEezisw&list=TLPQMjgxMDIwMjLsXaHKig8_jw&index=1&ab_channel=WesDoyle
/// ~34:00mins
/// </summary>
void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IMathFunctionsService, MathFunctionsService>();
}