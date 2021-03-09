using LD.DocMan.Application.Models.NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LD.DocMan.Application.Contracts.Infrastructure.NServiceBus
{
    public interface INServiceBusService
    {
        Task<bool> SendServiceBusMessage(ServiceBusMessage message);
    }
}
