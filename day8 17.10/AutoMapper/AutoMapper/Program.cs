
using AutoMapperProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using AutoMapper;
using System;

namespace AutoMapperProject

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            static void ConfigurationServices(IServiceCollection services)
            {
                services.AddAutoMapper(typeof(Program));
                services.AddControllers();
            }

            // automapper 
            // Add services to the container.
            builder.Services.AddDbContext<PersonalDetailsContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("connection")); });


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            
            static void  AppMigration(WebApplication? App)
            {
                
                    using (var scope = App.Services.CreateScope())
                    {
                        var _db = scope.ServiceProvider.GetRequiredService<PersonalDetailsContext>();
                        if (_db.Database.GetPendingMigrations().Any())
                        {
                            _db.Database.Migrate();
                        }
                    }
                

            }
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
