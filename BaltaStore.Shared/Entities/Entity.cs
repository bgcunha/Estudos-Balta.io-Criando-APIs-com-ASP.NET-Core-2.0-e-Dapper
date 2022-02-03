using FluentValidator;
using System;


namespace BaltaStore.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            Id = new Guid();
        }

        public Guid Id { get; private set; }

       
    }
}
