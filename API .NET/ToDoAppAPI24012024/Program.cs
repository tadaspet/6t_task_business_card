
using Microsoft.EntityFrameworkCore;
using ToDoApp.BLL.Extensions;
using ToDoApp.DAL.AppDbContext;
using ToDoApp.DAL.Entities;
using ToDoApp.DAL.Extensions;

namespace ToDoAppAPI24012024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add services to the container.
            //builder.Services.AddTransient<IEmailServices, EmailServices>();  <---- cia iprastas budas, bet galima kitaip
            builder.Services.AddBussinessLogic();
            builder.Services.AddDataBaseServices();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));
            });

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
