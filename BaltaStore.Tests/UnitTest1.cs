using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name ( "Bruno", "Cunha" );

            var customer = new Customer( name,"12365478900", "bruno.gomes@gmail.com", "4335420000", "Rua A - Bandeirantes - Paraná 86360000");

            var order = new Order(customer);
            
        }
    }
}
