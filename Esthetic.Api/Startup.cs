using System;
using System.Text;
using Esthetic.Core.Contracts.Utilities;
using Esthetic.Utility;
using FluentValidation.AspNetCore;
using Esthetic.Core.Contracts.Data;
using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.DataAccess.EF;
using Esthetic.DataAccess.Repositories;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Model;
using Esthetic.Service;
using Esthetic.Service.Contracts;
using Esthetic.Utility.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;

namespace Esthetic.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation();
            services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<ICompanyService, CompanyService>();

            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();

            services.AddTransient<ITokenHelper, JwtHelper>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddSingleton<IStringUtility, StringUtility>();

            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new OpenApiInfo());
            });

            //services.AddDbContext<IDbContext, Context>(options =>
            //{
            //    options.UseMySQL(Configuration["ConnectionStrings:DefaultConnection"]);
            //});


            services.AddDbContext<IDbContext, Context>(options =>
            {
                var connectionString = Configuration["ConnectionStrings:DefaultConnection"];
                options.UseMySql(connectionString,
                        ServerVersion.AutoDetect(connectionString),
                        mySqlOptions =>
                            mySqlOptions.EnableRetryOnFailure(
                                10,
                                TimeSpan.FromSeconds(30),
                                null)

                    );
            });

            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptionsModel>();

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = tokenOptions.Issuer,
                    ValidAudience = tokenOptions.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))
                };
            });

        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseRouting();
            app.UseCors("corsapp");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(options => {
                options.DocumentTitle = "Esthetic API";
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Esthetic Api Documentation");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MVC didn't find anything!");
            });

            
        }
    }
}
