using BaltaStore.Domain.StoreContext.Entities;

namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Document : Entity
    {
        public Document(string number)
        {
            if (number.Length != 11)
            {
                AddNotification("Document", "Cpf invalido");
                return;
            }

            Number = number;
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
