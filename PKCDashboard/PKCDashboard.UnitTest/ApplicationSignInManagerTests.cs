using System;
using PKCDashboard.Web;
using PKCDashboard.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace PKCDashboard.UnitTest
{
    [TestClass]
    public class ApplicationSignInManagerTests
    {
        Mock<ApplicationUserManager> applicationUserManager;
        Mock<IAuthenticationManager> authenticationManager;
        ApplicationSignInManager applicationSignInManager;
        Mock<IUserStore<ApplicationUser>> store;
        ApplicationUser applicationUser;
        public ApplicationSignInManagerTests()
        {
            store = new Mock<IUserStore<ApplicationUser>>();
            applicationUserManager = new Mock<ApplicationUserManager>(store.Object);
            authenticationManager = new Mock<IAuthenticationManager>();
            applicationSignInManager = new ApplicationSignInManager(applicationUserManager.Object, authenticationManager.Object);
            applicationUser = new ApplicationUser();
        }

        [TestMethod]
        public void CreateUserIdentityAsync_Tests()
        {
            applicationSignInManager.CreateUserIdentityAsync(applicationUser);
        }

        [TestMethod]
        public void Create_Tests()
        {
            //ApplicationSignInManager.Create(null, null);
        }
    }
}
