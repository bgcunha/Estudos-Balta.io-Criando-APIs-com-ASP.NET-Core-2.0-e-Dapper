using BaltaStore.Domain.StoreContext.Entities;
using FluentValidator.Validation;

namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Email : Entity
    {
        public string Address { get; private set; }

        public Email(string address)
        {
            Address = address;

            AddNotifications(new ValidationContract()
                   .Requires()
                   .IsEmail(Address, "Email", "E-mail inválido.")
               );
        }

        public override string ToString()
        {
            return Address;
        }
    }
}
