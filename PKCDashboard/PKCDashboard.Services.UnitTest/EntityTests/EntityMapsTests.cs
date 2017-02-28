using System;
using PKCDashboard.Entities.Context;
using PKCDashboard.Entities.Mappings;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PKCDashboard.Services.UnitTest
{
    [TestClass]
    public class EntityMapsTests
    {
        [TestMethod]
        public void CategoryMapTests()
        {
            CategoryMap map = new CategoryMap();
        }

        [TestMethod]
        public void SupplierMapTests()
        {
            SupplierMap map = new SupplierMap();
        }

        [TestMethod]
        public void NorthWindContext()
        {
            NorthwindDataContext context = new NorthwindDataContext();
        }
    }
}
