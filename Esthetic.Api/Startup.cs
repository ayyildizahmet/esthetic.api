using System;
using System.Text;
using FluentValidation.AspNetCore;
using MakeEat.Core.Contracts.Data;
using MakeEat.Core.Contracts.UnitOfWork;
using MakeEat.DataAccess.EF;
using MakeEat.DataAccess.Repositories;
using MakeEat.DataAccess.Repositories.Contracts;
using MakeEat.Model;
using MakeEat.Service;
using MakeEat.Service.Contracts;
using MakeEat.Utility.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;


namespace MakeEat.Api
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
            
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAddressService, AddressService>();

            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            
            services.AddTransient<ITokenHelper, JwtHelper>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(options => {
                options.DocumentTitle = "MakeEat API";
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "MakeEat Api Documentation");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
