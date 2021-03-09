using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.Documents.Common.GetDocumentBinary
{
    public class DocumentFileVM
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
