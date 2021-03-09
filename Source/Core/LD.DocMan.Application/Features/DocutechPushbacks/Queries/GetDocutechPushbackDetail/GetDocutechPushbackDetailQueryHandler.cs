using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocutechPushbacks.Queries.GetDocutechPushbackDetail
{
    public class GetDocutechPushbackDetailQueryHandler : IRequestHandler<GetDocutechPushbackDetailQuery, DocutechPushbackDetailVM>
    {
        private readonly IAsyncRepository<DocutechPushbackDetailVM> _docutechPushbackRepository;
        private readonly IMapper _mapper;

        public GetDocutechPushbackDetailQueryHandler(IAsyncRepository<DocutechPushbackDetailVM> docutechPushbackRepository, IMapper mapper)
        {
            _docutechPushbackRepository = docutechPushbackRepository;
            _mapper = mapper;   
        }

        public async Task<DocutechPushbackDetailVM> Handle(GetDocutechPushbackDetailQuery request, CancellationToken cancellationToken)
        {
            var docutechPushbackDetail = await _docutechPushbackRepository.GetByIdAsync(request.Id);
            var docutechPushbackDetailDto = _mapper.Map<DocutechPushbackDetailVM>(docutechPushbackDetail);
            return docutechPushbackDetailDto;
        }
    }
}
