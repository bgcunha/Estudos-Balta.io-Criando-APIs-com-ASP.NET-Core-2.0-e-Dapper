using BaltaStore.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Order : Entity
    {
        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;
        public Order(Customer customer)
        {
            Customer = customer;
            //Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();
        }

        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public void AddItem(Product product, decimal quantity)
        {
            if (quantity > product.QuantityOnHand)
            {
                AddNotification("OrderItem", $"O produto {product.Title} não tem {quantity} itens no estoque");
                return;
            }

            var item = new OrderItem(product, quantity);
            _items.Add(item);
        }

        public void Place()
        {
            if (_items.Count == 0)
            {
                AddNotification("Order", "Pedido sem itens.");
                return;
            }

            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        }

        public void Pay()
        {
            Status = EOrderStatus.Paid;
        }

        public void Ship()
        {
            // A cada 5 produtos é uma entrega
            var deliveries = new List<Delivery>();

            if (_items.Count > 5)
            {
                var itens = 0;
                // Quebra as entregas
                foreach (var item in _items)
                {
                    itens++;
                    if (itens == 5)
                    {
                        itens = 0;
                        deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                    }
                }
            }
            else 
            {
                deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            }

            // Envia todos as entregas
            deliveries.ForEach(x => x.Ship());

            // Adiciona as entregas ao pedido
            deliveries.ForEach(x => _deliveries.Add(x));

        }

        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
            _deliveries.ToList().ForEach(x => x.Cancel());
        }

    }
}