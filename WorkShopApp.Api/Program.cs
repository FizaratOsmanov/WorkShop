using Microsoft.EntityFrameworkCore;
using WorkShopApp.BL.Services.Abstractions;
using WorkShopApp.BL.Services.Implementations;
using WorkShopApp.Data.DAL;
using WorkShopApp.Data.Repositories.Abstractions;
using WorkShopApp.Data.Repositories.Implementations;

namespace WorkShopApp.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddScoped<IWorkShopRepository, WorkShopRepository>();
        builder.Services.AddScoped<IWorkShopService, WorkShopService>();

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("FizaretSQL"));
        });
        var app = builder.Build();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
