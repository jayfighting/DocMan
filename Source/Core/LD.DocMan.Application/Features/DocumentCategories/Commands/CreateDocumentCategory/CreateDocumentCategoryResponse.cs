using System;
using System.Collections.Generic;
using System.Text;
using LD.DocMan.Application.Responses;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.CreateDocumentCategory
{
    public class CreateDocumentCategoryResponse : BaseResponse
    {
        public CreateDocumentCategoryResponse() : base()
        { }

        public CreateDocumentCategoryDto DocumentCategory { get; set; }
    }
}
