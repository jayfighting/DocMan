using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.UpdateDocumentCategory
{
    public class UpdateDocumentCategoryCommand: IRequest
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public Guid ParentId { get; set; }
    }
}
