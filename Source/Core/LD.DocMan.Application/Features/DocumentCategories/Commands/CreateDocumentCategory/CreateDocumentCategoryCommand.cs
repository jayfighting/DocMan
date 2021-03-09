using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.CreateDocumentCategory
{
    public class CreateDocumentCategoryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public Guid ParentId { get; set; }
    }
}
