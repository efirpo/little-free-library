using System.Collections.Generic;
using System.Text;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
// using Library.Authorization;
using Library.Options;

//TROUBLESHOOTING AUTHENTICATION
// https://jasonwatmore.com/post/2018/08/14/aspnet-core-21-jwt-authentication-tutorial-with-example-api
namespace Library.Installers
{
  public class MvcInstaller : IInstaller
  {
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
      var jwtSettings = new JwtSettings();
      configuration.Bind(nameof(jwtSettings), jwtSettings);
      services.AddSingleton(jwtSettings);

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      services.AddAuthentication(configureOptions: auth =>
      {
        auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
      })
      .AddJwtBearer(auth =>
      {
        auth.SaveToken = true;
        auth.TokenValidationParameters = new TokenValidationParameters
        {
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.Secret)),
          ValidateIssuer = false,
          ValidateAudience = false,
          RequireExpirationTime = false,
          ValidateLifetime = true
        };
      });

      services.AddSwaggerGen(swag =>
      {
        swag.SwaggerDoc("v1", new OpenApiInfo { Title = "Little Free Library API", Version = "v1" });

        var security = new Dictionary<string, IEnumerable<string>>
        {
          {"Bearer", new string[0]}
        };
        swag.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
          Description = "JWT Authorization header using the bearer scheme",
          Name = "Authorization",
          In = ParameterLocation.Header,
          Type = SecuritySchemeType.ApiKey
        });
        swag.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
          {new OpenApiSecurityScheme{Reference = new OpenApiReference
          {
            Id="Bearer",
            Type = ReferenceType.SecurityScheme
          }}, new List<string>()}
        });
      });
    }
  }
}