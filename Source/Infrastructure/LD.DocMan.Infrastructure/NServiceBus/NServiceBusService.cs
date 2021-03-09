using System.Threading.Tasks;
using LD.DocMan.Application.Contracts.Infrastructure.NServiceBus;
using LD.DocMan.Application.Models.NServiceBus;

namespace LD.DocMan.Infrastructure.NServiceBus
{
    public class NServiceBusService : INServiceBusService
    {
        public async Task<bool> SendServiceBusMessage(ServiceBusMessage message)
        {
            return true;
            //ToDo: Add Service Bus logic here 
        }
    }
}
