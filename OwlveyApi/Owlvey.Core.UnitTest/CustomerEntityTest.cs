using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Owlvey.Core.UnitTest
{
    [TestClass]
    public class CustomerEntityTest
    {
        [TestMethod]
        public void MaintenanceCustomerEntity()
        {
            CustomerEntity entity = CustomerEntity.Create("test");
            Assert.IsNotNull(entity);
        }        
        
    }
}
