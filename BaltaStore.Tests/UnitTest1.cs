using BaltaStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customer = new Customer("Bruno","Cunha","12365478900", "bruno.gomes@gmail.com", "4335420000", "Rua A - Bandeirantes - Paraná 86360000");

            var order = new Order(customer);
            
        }
    }
}
