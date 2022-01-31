
namespace BaltaStore.Domain.StoreContext.Entities
{
    public class OrderItem: Entity
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;

            if (product.QuantityOnHand < Quantity)
                AddNotification("Quantity", "Quantidade insuficiente no estoque.");
        }

        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}