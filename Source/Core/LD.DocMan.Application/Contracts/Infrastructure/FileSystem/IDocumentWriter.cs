using System;
using System.Collections.Generic;
using System.Text;
using LD.DocMan.Application.Features.Documents.Common.GetDocumentBinary;

namespace LD.DocMan.Application.Contracts.Infrastructure.FileSystem
{
    public interface IDocumentWriter
    {
        public string WriteDocument(List<DocumentFileVM> addDocumentDtos);
    }
}
