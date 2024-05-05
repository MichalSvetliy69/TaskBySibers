using Microsoft.EntityFrameworkCore;
using TaskBySibers.Data.Context;
using TaskBySibers.Mapping;

namespace TaskBySibers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<MSSQLContext>(options =>
            {
                string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString); // Используем MS SQL Server

            });


            builder.Services.AddAutoMapper(typeof(ProjectMap));

            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}