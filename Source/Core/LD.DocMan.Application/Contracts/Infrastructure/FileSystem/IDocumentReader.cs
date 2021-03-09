using System;
using System.Collections.Generic;
using System.Text;
using LD.DocMan.Application.Features.Documents.Queries.GetDocumentBinary;

namespace LD.DocMan.Application.Contracts.Infrastructure.FileSystem
{
    public interface IDocumentReader
    {
        byte[] ReadDocument(DocumentBinaryDto documentBinaryDto);
    }
}
