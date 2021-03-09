using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LD.DocMan.Application.Features.DocumentTypes.Commands.CreateDocumentType;
using LD.DocMan.Application.Features.DocumentTypes.Commands.UpdateDocumentType;
using LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeDetail;
using LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeList;
using MediatR;

namespace LD.DocMan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DocumentTypeController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet("all", Name = "GetAllDocumentTypes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DocumentTypeListVM>>> GetAllDocumentTypes()
        {
            var documentTypeListDto = await _mediator.Send(new GetDocumentTypeListQuery());
            return Ok(documentTypeListDto);
        }

        [HttpGet("{id}", Name = "GetDocumentTypeById")]
        public async Task<ActionResult<DocumentTypeDetailVM>> GetDocumentTypeById(Guid id)
        {
            var getDocumentTypeDetailQuery = new GetDocumentTypeDetailQuery() {Id = id};
            return Ok(await _mediator.Send(getDocumentTypeDetailQuery));
        }

        [HttpPost(Name = "CreateDocumentType")]
        public async Task<ActionResult<Guid>> Create(
            [FromBody] CreateDocumentTypeCommand createDocumentTypeCommand)
        {
            var response = await _mediator.Send(createDocumentTypeCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateDocumentType")]
        [ProducesResponseType((StatusCodes.Status204NoContent))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> update([FromBody] UpdateDocumentTypeCommand updateDocumentTypeCommand)
        {
            await _mediator.Send(updateDocumentTypeCommand);
            return NoContent();
        }


    }
}
