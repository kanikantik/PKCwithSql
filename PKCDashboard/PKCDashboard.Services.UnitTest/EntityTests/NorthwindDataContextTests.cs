using System;
using PKCDashboard.Entities.Context;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PKCDashboard.Services.UnitTest
{
    [TestClass]
    public class NorthwindDataContextTests : NorthwindDataContext
    {
        [TestMethod]
        public void NorthwindDataContext_Tests()
        {
            NorthwindDataContext context = new NorthwindDataContext();
            context.Suppliers = null;
            var con = context.Suppliers;
            base.OnModelCreating(new System.Data.Entity.DbModelBuilder());
            context.Categories = null;
            var conCat = context.Categories;
        }
    }
}
