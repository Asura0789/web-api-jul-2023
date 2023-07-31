
namespace EmployeesHrApi
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

            //above this is behind the scenes for API
            var app = builder.Build();
            //after this is the middle ware

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger(); //Lets you pull documentaion
                app.UseSwaggerUI(); //makex UI to view documentation pulled
            }

            app.UseAuthorization(); //security added here


            app.MapControllers(); // used to create lookup table

            app.Run();
        }
    }
}