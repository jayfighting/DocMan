using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryList
{
    public class DocumentCategoryListVM
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public Guid ParentId { get; set; }
    }
}
