using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CapstoneTestPRS.Data;

namespace CapstoneTestPRS;

public class Program {
    public static void Main(string[] args) {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<PrsDbContext>(options =>

            options.UseSqlServer(builder.Configuration.GetConnectionString("Test") ?? throw new InvalidOperationException("Connection string 'PrsDbContext' not found.")));

        builder.Services.AddControllers();


        // Add services to the container.

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
