using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeList
{
    public class DocumentTypeListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
    }
}
