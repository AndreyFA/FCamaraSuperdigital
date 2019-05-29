using API.ContaCorrente.Infrastructure;
using Core.SuperdigitalContaCorrenteApplications.Infrastructure;
using Core.SuperdigitalContaCorrenteRepositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.ContaCorrente
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private readonly string _appVersion = "1.0";
        private readonly string _appTitle = "Superdigital Conta Corrente API.";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppContexto>(o => o.UseInMemoryDatabase());
            services.RegisterRepositories();
            services.RegisterServices();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerDocumentation(_appVersion, _appTitle);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerDocumentation(_appVersion, _appTitle);
            app.UseMvc();
        }
    }
}
