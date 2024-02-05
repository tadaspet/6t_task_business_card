
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RegisterPersonApi.BLL.Extensions;
using RegisterPersonApi.DAL.ApiDbContext;
using RegisterPersonApi.DAL.Extensions;
using RegisterPersonAPI.Mappers;
using RegisterPersonAPI.Mappers.Interfaces;
using System.Reflection;

namespace RegisterPersonAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<RegisterDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ExamDataBase"))
            );
            builder.Services.AddBussinessLayer();
            builder.Services.AddDataLayer();
            builder.Services.AddTransient<IUserMapper, UserMapper>();
            builder.Services.AddTransient<IPersonInfoMapper, PersonInfoMapper>();

            //builder.Services.AddCors(options => 
            //    options.AddPolicy("AllowLocalhost", builder => builder.WithOrigins("http://127.0.0.1:5500")
            //                  .AllowAnyHeader()
            //                  .AllowAnyMethod())
            //);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v0.0001",
                    Title = "Person Registration API",
                    Description = "Person Registration ASP.NET Core Web API.\n <<-THE FINAL EXAM->>.",
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                opt.IncludeXmlComments(xmlPath);

                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please ender valid JWT token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT"
                });
                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme{Reference = new OpenApiReference
                        {
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }}, new List<string>()
                    }
                });
            });

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   var secretKey = builder.Configuration.GetSection("Jwt:Key").Value;
                   var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey));
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = builder.Configuration.GetSection("Jwt:Issuer").Value,
                       ValidAudience = builder.Configuration.GetSection("Jwt:Audience").Value,
                       IssuerSigningKey = key
                   };
               });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            //app.UseCors("AllowLocalhost");
            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
