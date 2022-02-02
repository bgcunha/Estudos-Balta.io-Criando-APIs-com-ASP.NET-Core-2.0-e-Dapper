using BaltaStore.Shared.Commands;
using System;

namespace BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Outputs
{
    public class CreateCustomerCommandResult : ICommandResult
    {
        public CreateCustomerCommandResult(){}
        public CreateCustomerCommandResult(Guid id, string Name, string email)
        {
            Id = id;
            Name = Name;
           
            Email = email;
            
        }

        public Guid Id { get; set; }
        public string Name { get; set; }        
        public string Email { get; set; }
       

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
