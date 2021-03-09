using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Application.Models.ThirdParty.Docutech;
using MediatR;

namespace LD.DocMan.Application.Features.DocutechPushbacks.Commands.AddDocutechPushback
{
    public class AddDocutechPushbackCommandHandler : IRequestHandler<AddDocutechPushbackCommand, Guid>
    {
        private IAsyncRepository<DocutechPushback> _docutechPushbackRepository;
        private readonly IMapper _mapper;

        public AddDocutechPushbackCommandHandler(IAsyncRepository<DocutechPushback> docutechPushbackRepository, IMapper mapper)
        {
            _docutechPushbackRepository = docutechPushbackRepository;
            _mapper = mapper;   
        }

        public async Task<Guid> Handle(AddDocutechPushbackCommand request, CancellationToken cancellationToken)
        {
            var docutechPushback = _mapper.Map<DocutechPushback>(request);
            docutechPushback = await _docutechPushbackRepository.AddAsync(docutechPushback);
            return docutechPushback.DocutechPushbackId;
        }
    }
}
