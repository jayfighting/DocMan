using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryDetails
{
    public class GetDocumentCategoryDetailsQueryHandler : IRequestHandler<GetDocumentCategoryDetailsQuery, DocumentCategoryDetailsVM>
    {
        private readonly IAsyncRepository<DocumentCategoryDetailsVM> _documentCategoryDetailRepository;
        private readonly IMapper _mapper;

        public GetDocumentCategoryDetailsQueryHandler(IAsyncRepository<DocumentCategoryDetailsVM> documentCategoryDetailRepository, IMapper mapper)
        {
            _documentCategoryDetailRepository = documentCategoryDetailRepository;
            _mapper = mapper;   
        }

        public async Task<DocumentCategoryDetailsVM> Handle(GetDocumentCategoryDetailsQuery request, CancellationToken cancellationToken)
        {
            var documentCategoryDetail = await _documentCategoryDetailRepository.GetByIdAsync(request.Id);
            var documentCategoryDetailDto = _mapper.Map<DocumentCategoryDetailsVM>(documentCategoryDetail);
            return documentCategoryDetailDto;
        }
    }
}
