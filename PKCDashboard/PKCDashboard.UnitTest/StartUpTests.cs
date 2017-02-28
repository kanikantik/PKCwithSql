using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKCDashboard.Web;
using Microsoft.Owin.Builder;
using Owin;
using PKCDashboard.Web.Models;
using Microsoft.AspNet.Identity;
using Moq;

namespace PKCDashboard.UnitTest
{
    [TestClass]
    public class StartUpTests
    {
        [TestMethod]
        public void StartUp_Tests()
        {
            IAppBuilder app = new AppBuilder();
            PKCDashboard.Web.Startup startUp = new Web.Startup();
            startUp.ConfigureAuth(app);
        }

        [TestMethod]
        public void ApplicationUser_Tests()
        {
            Mock<IUserStore<ApplicationUser>> interUser = new Mock<IUserStore<ApplicationUser>>();
            UserManager<ApplicationUser> manager = new UserManager<ApplicationUser>(interUser.Object);
            ApplicationUser user = new ApplicationUser();
            user.GenerateUserIdentityAsync(manager);
        }
    }
}
