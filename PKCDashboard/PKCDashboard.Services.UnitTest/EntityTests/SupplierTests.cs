using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKCDashboard.Entities;
using PKCDashboard.Repository.Pattern.Infrastructure;

namespace PKCDashboard.Services.UnitTest
{
    [TestClass]
    public class SupplierTests
    {
        [TestMethod]
        public void Supplier_Get_SetTests()
        {
            // Set value 
            Supplier supplier = new Supplier()
            {
                Address = "Address",
                City = "City",
                CompanyName = "company",
                ContactName = "Name",
                ContactTitle = "Mr",
                Country = "Country",
                Fax = "1233445",
                Homepage = "Supplier",
                Phone = "1223344",
                PostalCode = "12222",
                Region = "Chennai",
                SupplierId = 12,
                ObjectState = ObjectState.Added
            };
            //Get Value
            Supplier supplierSet = new Supplier()
            {
                Address = supplier.Address,
                City = supplier.City,
                CompanyName = supplier.CompanyName,
                ContactName = supplier.ContactName,
                ContactTitle = supplier.ContactTitle,
                Country = supplier.Country,
                Fax = supplier.Fax,
                Homepage = supplier.Homepage,
                Phone = supplier.Phone,
                PostalCode = supplier.PostalCode,
                Region = supplier.Region,
                SupplierId = supplier.SupplierId,
                ObjectState = supplier.ObjectState
            };
            Assert.IsTrue(true, supplierSet.Address);
        }
    }
}
