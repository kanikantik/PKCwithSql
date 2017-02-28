using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKCDashboard.Entities;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKCDashboard.Repository.Ef6.Fakes;
using PKCDashboard.Repository.Pattern.Infrastructure;

namespace PKCDashboard.Services.UnitTest
{
    /// <summary>
    /// FakeDbSetTest
    /// </summary>
    [TestClass]
    public class FakeDbSetTest : FakeDbSet<Category>
    {
        /// <summary>
        /// Gets the enumerator tests.
        /// </summary>
        [TestMethod]
        public void GetEnumeratorTests()
        {
            var result = base.GetEnumerator();
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Adds the tests.
        /// </summary>
        [TestMethod]
        public void AddTests()
        {
            Category category = new Category();
            var result = base.Add(category);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Removes the tests.
        /// </summary>
        [TestMethod]
        public void RemoveTests()
        {
            Category category = new Category();
            var result = base.Remove(category);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Attaches the tests.
        /// </summary>
        [TestMethod]
        public void AttachTests()
        {
            Category category = new Category() { ObjectState = ObjectState.Modified };
            Category category1 = new Category() { ObjectState = ObjectState.Deleted };
            Category category2 = new Category() { ObjectState = ObjectState.Unchanged };
            var modify = base.Attach(category);
            var delete = base.Attach(category1);
            var unchanged = base.Attach(category2);
            Assert.IsNotNull(modify);
            Assert.IsNotNull(delete);
            Assert.IsNotNull(unchanged);
        }

        /// <summary>
        /// Creates the tests.
        /// </summary>
        [TestMethod]
        public void CreateTests()
        {
            Category category = new Category();
            var result = base.Create();
            Assert.IsNotNull(result);
        }

    }
}
