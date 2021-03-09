using System;
using System.Collections.Generic;
using System.Text;
using LD.DocMan.Application.Responses;

namespace LD.DocMan.Application.Features.Documents.Commands.AddDocument
{
    public class AddDocumentResponse : BaseResponse
    {
        public AddDocumentResponse() : base()
        {
        }

        public AddDocumentDto Document { get; set; }
    }
}
