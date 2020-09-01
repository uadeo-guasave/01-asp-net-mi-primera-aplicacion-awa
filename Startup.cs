using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_asp_net_mi_primera_aplicacion.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _01_asp_net_mi_primera_aplicacion
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapGet("/", async context =>
              {
                await context.Response.WriteAsync("Hola Mundo!");
              });

        endpoints.MapGet("alumnos", async context =>
        {
          var alumno = new Alumno
          {
              Id=1,
              Nombre="Karen",
              Apellidos="Estrada",
              CorreoElectronico="karen@estrada.com"
          };
          await context.Response.WriteAsync(alumno.ToString());
        });
      });
    }
  }
}
