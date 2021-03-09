using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LD.DocMan.Application.Features.Documents.Commands.CreateDocument;
using LD.DocMan.Application.Features.Documents.Commands.UpdateDocument;
using LD.DocMan.Application.Features.Documents.Queries.GetDocumentDetail;
using LD.DocMan.Application.Features.Documents.Queries.GetDocumentList;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace LD.DocMan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : Controller
    {
        private IMediator _mediator;

        public DocumentController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet("all", Name = "GetAllDocuments")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DocumentListVM>>> GetAllDocumentTypes()
        {
            var documentTypeListDto = await _mediator.Send(new GetDocumentListQuery());
            return Ok(documentTypeListDto);
        }

        [HttpGet("{id}", Name = "GetDocumentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DocumentListVM>>> GetDocumentById(Guid id)
        {
            var getDocumentDetailQuery = new GetDocumentDetailQuery() {Id = id};
            return Ok(await _mediator.Send(getDocumentDetailQuery));
        }

        [HttpPost(Name = "AddDocument")]
        public async Task<ActionResult<Guid>> Create([FromBody] AddDocumentCommand addDocumentCommand)
        {
            var id = await _mediator.Send(addDocumentCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateDocument")]
        [ProducesResponseType((StatusCodes.Status204NoContent))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> update([FromBody] UpdateDocumentCommand updateDocumentCommand)
        {
            await _mediator.Send(updateDocumentCommand);
            return NoContent();
        }
    }
}
