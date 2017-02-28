// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MvcApplication.cs" company="EPAM Systems">
//   Copyright 2015
// </copyright>
// <summary>
//   The MvcApplication.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PKCDashboard.Web
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System;
    using System.Web.Optimization;
    using System.Web.Routing;
    using StackExchange.Profiling;
    using StackExchange.Profiling.EntityFramework6;
    using StackExchange.Profiling.SqlFormatters;

    /// <summary>
    ///     Mvc Application
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Application_s the start.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MiniProfilerEF6.Initialize();
            MiniProfiler.Settings.SqlFormatter = new SqlServerFormatter();
        }

        protected void Application_BeginRequest()
        {
            if (Request.IsLocal)
            {
                MiniProfiler.Start();
            }
        }

        protected void Application_EndRequest()
        {
            MiniProfiler.Stop();
        }
    }
}
