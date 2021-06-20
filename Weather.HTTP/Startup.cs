using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Weather.HTTP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddMvc();

            services.AddScoped<Data.Access.Countries.Get.IGetCountries, Data.Access.Countries.Get.Mock>();
            services.AddScoped<Services.Countries.Get.IGetCountries, Services.Countries.Get.GetCountries>();

            services.AddScoped<Data.Access.Cities.Get.IGetCities, Data.Access.Cities.Get.Mock>();
            services.AddScoped<Services.Cities.Get.IGetCities, Services.Cities.Get.GetCities>();


            // switch weather data source
            var weatherDataSource = Environment.GetEnvironmentVariable("WEATHER_DATA_SOURCE");
            if(weatherDataSource== "OpenWeatherMap")
            {
                services.AddHttpClient<Data.Access.Weathers.Get.IGetWeather, Data.Access.Weathers.Get.OpenWeatherMaps.OpenWeatherMap>(httpClient =>
                {
                    httpClient.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/weather");
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                });
            }
            else
            {
                services.AddScoped<Data.Access.Weathers.Get.IGetWeather, Data.Access.Weathers.Get.Mock>();
            }

            services.AddScoped<Services.Weathers.Get.IGetWeather, Services.Weathers.Get.GetWeather>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
