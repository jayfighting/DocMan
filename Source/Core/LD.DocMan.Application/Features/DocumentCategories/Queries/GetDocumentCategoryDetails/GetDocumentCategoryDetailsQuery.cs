using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryDetails
{
    public class GetDocumentCategoryDetailsQuery : IRequest<DocumentCategoryDetailsVM>
    {
        public Guid Id { get; set; }
    }
}
