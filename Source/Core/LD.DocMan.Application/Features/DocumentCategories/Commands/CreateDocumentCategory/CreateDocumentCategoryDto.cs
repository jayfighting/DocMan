using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.CreateDocumentCategory
{
    public class CreateDocumentCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public List<CreateDocumentCategoryDto> Children { get; set; }
    }
}
