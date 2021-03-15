using CSharpFunctionalExtensions;
using LD.DocMan.API.Utils;
using LD.DocMan.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace LD.DocMan.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected new IActionResult Ok()
        {
            return base.Ok(Envelope.Ok());
        }

        protected IActionResult Ok<T>(T result)
        {
            return base.Ok(Envelope.Ok(result));
        }

        protected IActionResult FromResult(Result result)
        {
            if (result.IsSuccess)
            {
                return Ok();
            }

            if (result.Error == Errors.General.NotFound().Code.ToString())
            {
                return NotFound(Envelope.Error(result.Error));
            }

            return BadRequest(Envelope.Error(result.Error));
        }
    }
}