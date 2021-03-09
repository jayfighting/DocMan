using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryList
{
    public class GetDocumentCategoryListQuery : IRequest<List<DocumentCategoryListVM>>
    {
    }
}
