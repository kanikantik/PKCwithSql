using System;
using System.Linq.Expressions;
using System.Threading;
using PKCDashboard.Entities;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKCDashboard.Repository.Ef6;
using PKCDashboard.Repository.Ef6.Fakes;
using PKCDashboard.Repository.Pattern.Repositories;

namespace PKCDashboard.Services.UnitTest
{
    [TestClass]
    public class FakeDbContextTests : FakeDbContext
    {
        [TestMethod]
        public void TestMethod1()
        {
            base.SaveChanges();
            base.SyncObjectState<Category>(new Category());
            CancellationToken ct;
            base.SaveChangesAsync(ct);
            base.SaveChangesAsync();
            base.Dispose();
        }
    }
}
