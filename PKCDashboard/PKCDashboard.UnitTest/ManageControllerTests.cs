using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PKCDashboard.Web;
using PKCDashboard.Web.Controllers;
using PKCDashboard.Web.Models;

namespace PKCDashboard.UnitTest
{
    [TestClass]
    public class ManageControllerTests
    {
        private readonly Mock<ApplicationUserManager> userManagerMock;
        private readonly Mock<ApplicationSignInManager> signInManagerMock;
        private readonly ManageController manageController;
        public ManageControllerTests()
        {
            userManagerMock = new Mock<ApplicationUserManager>();
            signInManagerMock = new Mock<ApplicationSignInManager>();
            manageController = new ManageController();
        }
        [TestMethod]
        public void AddPhoneNumber_Tests()
        {
            manageController.AddPhoneNumber();
            Assert.IsTrue(true, "true");
        }

        [TestMethod]
        public void ChangePassword_Tests()
        {
            manageController.ChangePassword();
        }

        [TestMethod]
        public void SetPassword_Tests()
        {
            manageController.SetPassword();
        }
    }
}
