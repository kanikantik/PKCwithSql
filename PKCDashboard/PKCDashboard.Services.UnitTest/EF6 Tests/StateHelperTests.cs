using System.Data.Entity;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKCDashboard.Repository.Ef6;
using PKCDashboard.Repository.Pattern.Infrastructure;

namespace PKCDashboard.Services.UnitTest
{
    [TestClass]
    public class StateHelperTests
    {
        [TestMethod]
        public void ConvertStateTest()
        {
            var added = StateHelper.ConvertState(ObjectState.Added);
            var modified = StateHelper.ConvertState(ObjectState.Modified);
            var deleted = StateHelper.ConvertState(ObjectState.Deleted);
            var unchanged = StateHelper.ConvertState(ObjectState.Unchanged);
            var detached = StateHelper.ConvertState(EntityState.Detached);
            var unchange = StateHelper.ConvertState(EntityState.Unchanged);
            var Add = StateHelper.ConvertState(EntityState.Added);
            var delete = StateHelper.ConvertState(EntityState.Deleted);
            var modify = StateHelper.ConvertState(EntityState.Modified);
            Assert.IsNotNull(added);
            Assert.IsNotNull(modified);
            Assert.IsNotNull(deleted);
            Assert.IsNotNull(unchanged);
            Assert.IsNotNull(detached);
            Assert.IsNotNull(unchange);
            Assert.IsNotNull(Add);
            Assert.IsNotNull(delete);
            Assert.IsNotNull(modify);
        }
    }
}
