using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Owlvey.Core.UnitTest
{
    [TestClass]
    public class UserEntityTest
    {
        [TestMethod]
        public void MaintenanceUserEntityTest()
        {
            var user = new UserEntity() {
                 Email = "test@test.com"
            };
            user.Create("test", DateTime.Now);
            Assert.IsNotNull(user);            
            user.Delete();
        }

        [TestMethod]
        public void CreateValidationTest() {
            Assert.ThrowsException<ApplicationException>(()=> {
                var user = new UserEntity();
                user.Create("", DateTime.Now);
            });
        }
    }
}
