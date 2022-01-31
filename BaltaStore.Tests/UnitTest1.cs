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
            var document = new Document("12345678911");
            var email = new Email("bruno@bruno.com");

            var customer = new Customer( name, document, email, "4335420000");

            var order = new Order(customer);

            var mouse = new Product("Mouse", "Rato", "mouse.png", 59.90M, 10);
            var tecldo = new Product("Teclado", "Teclado", "mouse.png", 159.80M, 10);
            var impressora = new Product("Impressora", "Impresssora", "mouse.png", 359.80M, 10);
            var cadeira = new Product("Cadeira", "Cadeira", "mouse.png", 559.80M, 10);
            
            

            //order.AddItem( new OrderItem(mouse, 5));
            //order.AddItem( new OrderItem(tecldo, 5));
            //order.AddItem( new OrderItem(cadeira, 5));
            //order.AddItem( new OrderItem(impressora, 5));
                  
            order.Place();

            var valid = order.IsValid;

            order.Pay();

            order.Ship();

            order.Cancel();
            
        }
    }
}
