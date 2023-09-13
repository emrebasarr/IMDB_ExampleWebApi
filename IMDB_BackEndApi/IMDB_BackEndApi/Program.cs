using IMDB_BackEndApi.Models;
using IMDB_BackEndApi.Repositories;
using IMDB_BackEndApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

//Api
builder.Services.AddControllers();

//Database Context
builder.Services.AddDbContext<ImdbDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Services
builder.Services.AddScoped<IMovieRepository, MovieServices>();

//CORS
builder.Services.AddCors(cors =>
{
    cors.AddPolicy("MovieOrigin", p =>
    {
        p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

var app = builder.Build();

app.UseRouting();

app.UseCors("MovieOrigin");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute
    (
        name: "ApiRoute",
        pattern: "api/{controller}/{action}/{id?}"
    );
});

app.Run();