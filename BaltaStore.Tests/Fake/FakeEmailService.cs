
using BaltaStore.Domain.StoreContext.Services;

namespace BaltaStore.Tests.Fake
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string from, string subject, string body)
        {
            
        }
    }
}
