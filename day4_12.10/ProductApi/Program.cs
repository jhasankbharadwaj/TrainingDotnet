
using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Repository;

namespace ProductApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ProductContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDB")));

            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();

            // Add services to the container. additional
            builder.Services.AddAuthorization();

            // Add authentication if needed (e.g., JWT or Cookie authentication) additional 
            //builder.Services.AddAuthentication(/* Your authentication scheme */);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddControllers();


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
