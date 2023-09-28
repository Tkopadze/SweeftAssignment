using Microsoft.EntityFrameworkCore;
using SweeftApiAbstractions.Services;
using SweeftApiDomain;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>(options =>
                options.UseSqlServer(
                    builder.Configuration["ConnectionString"],
                    b => b.MigrationsAssembly(typeof(DBContext).Assembly.FullName)));

builder.Services.AddScoped<ITeachersService, TeachersService>();

builder.Services.AddHttpClient<ICountryService, CountryService>(options =>
{
    options.BaseAddress = new Uri(builder.Configuration["CountrisURI"]);
});
//builder.Services.AddScoped<ICountryService, CountryService>();
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
