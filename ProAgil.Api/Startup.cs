using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using ProAgil.Repositorio.Contexto;
using ProAgil.Dominio.Interfaces;
using ProAgil.Repositorio.Repositorio;

namespace ProAgil.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {


           // var builder = new ConfigurationBuilder();
           // builder.AddJsonFile("config.json", optional: false, reloadOnChange: true);
            Configuration = configuration;
        }

   

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
             services.AddDbContext<DataContext>(o=>
                                                   o.UseSqlServer(connectionString, 
                                                       m=>m.MigrationsAssembly("ProAgil.Repositorio")));

            services.AddScoped<IEventoRepositorio, EventoRepositorio>();
            services.AddScoped<ITemaRepositorio, TemaRepositorio>();
            services.AddScoped<ILocalRepositorio, LoalRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProAgil.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProAgil.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
