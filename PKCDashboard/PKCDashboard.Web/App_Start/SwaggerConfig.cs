// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SwaggerConfig.cs" company="EPAM Systems">
//   Copyright 2015
// </copyright>
// <summary>
//   The SwaggerConfig
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.Web.Http;
using PKCDashboard.Web;
using Swashbuckle.Application;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace PKCDashboard.Web
{
    /// <summary>
    /// Swagger Config
    /// </summary>
    public static class SwaggerConfig
    {
        /// <summary>
        /// Registers this instance.
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "PKCDashboard.Web");
                })
                .EnableSwaggerUi(c =>
                {
                });
        }
    }
}