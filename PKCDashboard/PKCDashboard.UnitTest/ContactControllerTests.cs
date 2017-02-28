using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PKCDashboard.Web.Controllers;

namespace PKCDashboard.UnitTest
{
    [TestClass]
    public class ContactControllerTests
    {
        private readonly Mock<ContactsController> contactMock;
        public ContactControllerTests()
        {
            contactMock = new Mock<ContactsController>();
        }
        [TestMethod]
        public void Get_Tests()
        {
            contactMock.Object.Get();
        }

        [TestMethod]
        public void Add_Tests()
        {
            contactMock.Object.Add(new ContactsController.UserContact() { });
        }

        [TestMethod]
        public void Update_Tests()
        {
            contactMock.Object.UpdateUSer("1", new ContactsController.UserContact() { });
        }

        [TestMethod]
        public void Delete_Tests()
        {
            contactMock.Object.DeleteUser("1");
        }
    }
}
