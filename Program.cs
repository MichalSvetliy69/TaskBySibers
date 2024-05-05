using Microsoft.EntityFrameworkCore;
using TaskBySibers.Data.Context;
using TaskBySibers.Mapping;
using TaskBySibers.Models;
using TaskBySibers.Repository.Implementation;
using TaskBySibers.Repository.Interfaces;
using TaskBySibers.Services;
using TaskBySibers.Services.Implementation;
using TaskBySibers.Services.interfaces;

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
                options.UseSqlServer(connectionString); // Используем MS SQL Server;

            });

            builder.Services.AddTransient<ICRUDProjectService, CRUDProjectService>();
            builder.Services.AddTransient<ICRUDEmployeeService, CRUDEmployeeService>();
            builder.Services.AddTransient<BaseRepository<Project>>();
            builder.Services.AddTransient<BaseRepository<Employee>>();


            builder.Services.AddAutoMapper(typeof(ProjectMap), typeof(EmployeeMap));

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