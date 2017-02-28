using System;
using System.Linq.Expressions;
using PKCDashboard.Entities;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKCDashboard.Repository.Ef6;
using PKCDashboard.Repository.Pattern.Repositories;

namespace PKCDashboard.Services.UnitTest
{
    [TestClass]
    public class QueryObjectTests : QueryObject<Category>
    {
        Expression<Func<Category, bool>> query;

        [TestMethod]
        public void QueryObject_Tests()
        {
            query = null;
            base.Query();
            base.And(query);
            base.Or(query);
        }
    }
}
