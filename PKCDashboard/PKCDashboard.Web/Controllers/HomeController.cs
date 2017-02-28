// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="EPAM Systems">
//   Copyright 2015
// </copyright>
// <summary>
//   The home controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PKCDashboard.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Entities;
    using PKCDashboard.Service.Pattern;
    using StackExchange.Profiling;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        public HomeController()
        {
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Index()
        {
            var profiler = MiniProfiler.Current;
            using (profiler.Step("Set page title"))
            {
                ViewBag.Title = "Home Page";
            }
            return this.View();
        }

        /// <summary>
        /// The about.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        /// <summary>
        /// The contact.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";
            return this.View();
        }
    }
}