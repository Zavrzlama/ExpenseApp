using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using AutoMapper;
using ExpensesApp.API.DBContexts;
using ExpensesApp.API.Services;
using Microsoft.EntityFrameworkCore;

namespace ExpensesApp.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        private IConfiguration _configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<ExpenseAppContext>(o => o.UseNpgsql(_configuration["Database:ConnectionString"]));
            services.AddScoped<IClientRolesRepository, ClientRolesRepository>();
            services.AddScoped<IExpenseTypesRepository, ExpenseTypesRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            services.AddCors(options => options.AddPolicy("AllowEverything",builder => builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("AllowEverything");
            app.UseHttpsRedirection();
            app.UseMvc();
            
        }
    }
}