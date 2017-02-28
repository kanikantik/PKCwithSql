using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PKCDashboard.Repository.Pattern.Repositories;
using PKCDashboard.Service.Pattern;
using PKCDashboard.Web.Controllers;
using PKCDashboard.Entities;
using PKCDashboard.Services;

namespace PKCDashboard.UnitTest
{
    [TestClass]
    public class HomeControllerTests
    {
        private readonly HomeController homeController;

        public HomeControllerTests()
        {
            homeController = new HomeController();
        }

        [TestMethod]
        public void Index_Tests()
        {
            homeController.Index();
        }

        [TestMethod]
        public void About_Tests()
        {
            homeController.About();
        }

        [TestMethod]
        public void Contact_Tests()
        {
            homeController.Contact();
        }
    }
}
