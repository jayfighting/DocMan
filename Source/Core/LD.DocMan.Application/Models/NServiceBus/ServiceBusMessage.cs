using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Models.NServiceBus
{
    public class ServiceBusMessage
    {
        public string Queue { get; set; }
        public string Message { get; set; }
    }
}
