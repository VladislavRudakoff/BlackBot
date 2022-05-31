using System.Reflection;
using Bot.Common.Extensions;
using Bot.Logic.AppContext;
using Bot.Logic.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using Telegram.Contracts.Extensions;
using Telegram.Contracts.Settings;

namespace Bot.WebApi;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                };
            });

        services.AddOptions();

        services.AddDbContext<BotContext>(opt =>
                opt.UseNpgsql(Configuration.GetConnectionString("PostgreSQL")));

        services.AddCache(Configuration);

        services.AddSettings(Configuration);

        services.AddServices();

        services.AddFactories();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.RegisterTelegramApiSettings(Configuration);
        services.RegisterTelegramApiClient(Configuration, Configuration.BindConfig<TelegramClientSettings>());

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bot.WebApi", Version = "v1" });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BotWebApi v1"));
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
