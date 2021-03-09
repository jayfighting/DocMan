using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryList
{
    public class GetDocumentCategoryListQueryHandler : IRequestHandler<GetDocumentCategoryListQuery, List<DocumentCategoryListVM>>
    {
        private readonly IAsyncRepository<DocumentCategory> _documentCategoryRepository;
        private readonly IMapper _mapper;

        public GetDocumentCategoryListQueryHandler(IAsyncRepository<DocumentCategory> documentCategoryRepository, IMapper mapper)
        {
            _documentCategoryRepository = documentCategoryRepository;
            _mapper = mapper;   
        }

        public async Task<List<DocumentCategoryListVM>> Handle(GetDocumentCategoryListQuery request, CancellationToken cancellationToken)
        {
            var allDocumentCategories = (await _documentCategoryRepository.ListAllAsync()).OrderBy(dc => dc.Name);
            return _mapper.Map<List<DocumentCategoryListVM>>(allDocumentCategories);
        }
    }
}
