using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocutechPushbacks.Queries.GetDocutechPushbackList
{
    public class GetDocutechPushbackListRequestHandler : IRequestHandler<GetDocutechPushbackListRequest, List<DocutechPushbackListVM>>
    {
        private readonly IAsyncRepository<DocutechPushbackListVM> _docutechPushbackRepository;
        private readonly IMapper _mapper;

        public GetDocutechPushbackListRequestHandler(IAsyncRepository<DocutechPushbackListVM> docutechPushbackRepository, IMapper mapper)
        {
            _docutechPushbackRepository = docutechPushbackRepository;
            _mapper = mapper;   
        }
        public async Task<List<DocutechPushbackListVM>> Handle(GetDocutechPushbackListRequest request, CancellationToken cancellationToken)
        {
            var allDocutechPushbacks = (await _docutechPushbackRepository.ListAllAsync()).OrderBy(pb => pb.OrderId);
            return _mapper.Map<List<DocutechPushbackListVM>>(allDocutechPushbacks);
        }
    }
}
