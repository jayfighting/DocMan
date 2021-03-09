using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LD.DocMan.Application.Contracts.Infrastructure.FileSystem;
using LD.DocMan.Application.Features.Documents.Queries.GetDocumentBinary;

namespace LD.DocMan.Infrastructure.FileSystem
{
    public class DocumentReader : IDocumentReader
    {
        public byte[] ReadDocument(DocumentBinaryDto documentBinaryDto)
        {
            if (File.Exists(documentBinaryDto.Path))
            { }
            return null;
        }
    }
}
