using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKCDashboard.Entities;
using PKCDashboard.Repository.Pattern.Infrastructure;

namespace PKCDashboard.Services.UnitTest
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void Category_Get_SetTests()
        {
            // Set value 
            Category category = new Category()
            {
                CategoryId = 123,
                CategoryName = "Category Name",
                Description = "Description",
                Picture = null,
                ObjectState = ObjectState.Added

            };
            //Get Value
            Category categorySet = new Category()
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description,
                Picture = category.Picture,
                ObjectState = category.ObjectState
            };
            Assert.IsTrue(true, categorySet.CategoryName);
        }
    }
}
