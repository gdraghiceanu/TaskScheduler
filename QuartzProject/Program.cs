
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using QuartzProjcect.Quartz;
using QuartzProject.Quartz;

namespace QuartzProject
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

            builder.Services.AddSingleton<IJobFactory, SingletonJobFactory>();
            builder.Services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            builder.Services.AddHostedService<QuartzHostedService>();
            builder.Services.AddSingleton<DemoJob>();
            builder.Services.AddSingleton(new JobSchedule(jobType: typeof(DemoJob), cronExpression: "0/5 * * * * ?"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
