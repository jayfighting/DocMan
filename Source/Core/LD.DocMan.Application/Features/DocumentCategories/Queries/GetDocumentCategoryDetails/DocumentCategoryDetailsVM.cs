using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryDetails
{
    public class DocumentCategoryDetailsVM
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public Guid ParentId { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedByName { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
