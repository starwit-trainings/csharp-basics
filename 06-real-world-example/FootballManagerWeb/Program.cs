using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FootballManager.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FootballManagerContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FootballManagerContext") ?? throw new InvalidOperationException("Connection string 'FootballManagerContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
