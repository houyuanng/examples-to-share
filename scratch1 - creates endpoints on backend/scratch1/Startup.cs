using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace scratch1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddDefaultPolicy(configure => configure.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
            services.AddHealthChecks();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();
            app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // MapGet sets the endpoint
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Awaiting response");
                });

                endpoints.MapGet("/sensitive", async context =>
                {
                    await context.Response.WriteAsync("sensitive data");
                });

                app.Use(next => context =>
                {
                    Console.WriteLine($"2. Endpoint: {context.GetEndpoint()?.DisplayName ?? "(null)"}");
                    return next(context);
                });
            });
        }
     }
}
