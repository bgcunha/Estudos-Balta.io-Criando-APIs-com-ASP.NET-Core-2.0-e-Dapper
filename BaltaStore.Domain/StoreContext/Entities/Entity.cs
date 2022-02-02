using FluentValidator;


namespace BaltaStore.Domain.StoreContext.Entities
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; private set; }

    }
}
