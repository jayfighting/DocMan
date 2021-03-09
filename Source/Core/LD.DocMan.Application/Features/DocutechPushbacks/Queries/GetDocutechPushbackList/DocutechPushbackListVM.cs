using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocutechPushbacks.Queries.GetDocutechPushbackList
{
    public class DocutechPushbackListVM
    {
        public Guid DocutechPushbackId { get; set; }
        public Guid OrderId { get; set; }
        public string LoanNumber { get; set; }
        public string Reason { get; set; }
        public DateTime ReasonDateTime { get; set; }
        public string PackageType { get; set; }
    }
}
