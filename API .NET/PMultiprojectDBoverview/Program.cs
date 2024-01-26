
using Microsoft.EntityFrameworkCore;
using PMultiprojectWithDbAccessLayer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PMultiprojectDBoverview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<MultiProjectDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );
            //{
            //    //var connection = builder.Configuration.GetConnectionString("DefaultConnection");
            //    //options.UseSqlServer(connection, c => c.MigrationsAssembly("PhotoApi.DAL"));
            //});

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
        }
    }
}
