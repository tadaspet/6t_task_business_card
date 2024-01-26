
using FilesAPI_20240123.Database;
using FilesAPI_20240123.Services;
using Microsoft.EntityFrameworkCore;

namespace FilesAPI_20240123
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<FilesDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));
            });

            builder.Services.AddScoped<IDbRepository, DbRepository>();
            builder.Services.AddScoped<IImageFilesService, ImageFilesServices>();
            builder.Services.AddScoped<IDbThumbNailRepository, DbThumbNailRepository>();
            builder.Services.AddScoped<IThumbNailServices, ThumbNailServices>();

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
