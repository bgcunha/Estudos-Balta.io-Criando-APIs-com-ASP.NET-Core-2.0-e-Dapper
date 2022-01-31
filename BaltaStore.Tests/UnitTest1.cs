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
            Document document = new Document("12345678911");
            Email email = new Email("bruno@bruno.com");

            var customer = new Customer( name, document, email, "4335420000");

            var order = new Order(customer);
            
        }
    }
}
