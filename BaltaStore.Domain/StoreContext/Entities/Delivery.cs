using BaltaStore.Domain.StoreContext.Enums;
using System;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery : Entity
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Wainting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }
        //public IList<Order> Orders { get; private set; }

        public void Ship()
        {
            //Se a data for menor que atualo não entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            //Se o status estiver como entregue, não pode ser cancelado
            Status = EDeliveryStatus.Canceled;
        }
    }
}