
namespace BaltaStore.Domain.StoreContext.Entities
{
    public class OrderItem: Entity
    {
        public OrderItem(Product product, decimal quantity)
        {
            if (product.QuantityOnHand < quantity)
            {
                AddNotification("Quantity", "Quantidade insuficiente no estoque.");
                return;
            }

            Product = product;
            Quantity = quantity;
            Price = Product.Price;

            Product.DecreaseQuantity(quantity);
        }

        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}