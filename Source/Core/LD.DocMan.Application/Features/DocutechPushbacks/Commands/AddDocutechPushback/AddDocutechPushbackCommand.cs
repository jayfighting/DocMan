using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocutechPushbacks.Commands.AddDocutechPushback
{
    public class AddDocutechPushbackCommand : IRequest<Guid>
    {
        public Guid OrderId { get; set; }
        public string LoanNumber { get; set; }
        public string Reason { get; set; }
        public DateTime ReasonDateTime { get; set; }
        public string PackageType { get; set; }
        public bool ReDisclosure { get; set; }
        public bool ClosingDisclosure { get; set; }
        public string ConsentType { get; set; }
        public string Xml { get; set; }
    }
}
