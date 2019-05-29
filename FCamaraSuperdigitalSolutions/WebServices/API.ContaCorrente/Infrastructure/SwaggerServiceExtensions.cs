using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace API.ContaCorrente.Infrastructure
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services, string version, string title)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc($"v{version}", new Info { Title = $"{title} v{version}", Version = $"v{version}" });

                string[] files = Directory.GetFiles(AppContext.BaseDirectory, "*.xml");

                foreach (string file in files)
                    c.IncludeXmlComments(file);

                Dictionary<string, IEnumerable<string>> security = new Dictionary<string, IEnumerable<string>>
                {
                    {"Bearer", new string[] { }},
                };

                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });

                c.AddSecurityRequirement(security);

            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app, string version, string title)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"../swagger/v{version}/swagger.json", $"Versioned {title} API v{version}");
                c.DocExpansion(DocExpansion.None);
            });

            return app;
        }
    }
}
