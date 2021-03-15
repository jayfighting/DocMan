using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LD.DocMan.Application.Features.DocumentCategories.Commands.CreateDocumentCategory;
using LD.DocMan.Application.Features.DocumentCategories.Commands.UpdateDocumentCategory;
using LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryDetails;
using LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryList;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace LD.DocMan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentCategoryController : BaseController
    {
        private IMediator _mediator;

        public DocumentCategoryController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet("all", Name = "GetAllDocumentCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<DocumentCategoryListVM>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllDocumentTypes()
        {
            var documentTypeListDto = await _mediator.Send(new GetDocumentCategoryListQuery());
            return Ok(documentTypeListDto);
        }

        [HttpGet("{id}", Name = "GetDocumentCategoryById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<DocumentCategoryListVM>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDocumentCategoryById(Guid id)
        {
            var getDocumentCategoryDetailsQuery = new GetDocumentCategoryDetailsQuery() { Id = id };
            return Ok(await _mediator.Send(getDocumentCategoryDetailsQuery));
        }

        [HttpPost(Name = "AddDocumentCategory")]
        [ProducesResponseType(typeof(CreateDocumentCategoryResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Create(
            [FromBody] CreateDocumentCategoryCommand createDocumentCategoryCommand)
        {
            var response = await _mediator.Send(createDocumentCategoryCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateDocumentCategory")]
        [ProducesResponseType((StatusCodes.Status204NoContent))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> update([FromBody] UpdateDocumentCategoryCommand updateDocumentCategoryCommand)
        {
            await _mediator.Send(updateDocumentCategoryCommand);
            return NoContent();
        }

    }
}
