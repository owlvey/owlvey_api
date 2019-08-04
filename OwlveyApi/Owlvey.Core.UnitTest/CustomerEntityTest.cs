using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Owlvey.Core.UnitTest
{
    [TestClass]
    public class CustomerEntityTest
    {
        [TestMethod]
        public void MaintenanceCustomerEntity()
        {
            CustomerEntity entity = new CustomerEntity();
            entity.Create("test", DateTime.Now);
            Assert.IsNotNull(entity);
        }

        
    }
}
