using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Featuers.ReservationFeatuers.Commands;
using NokoodAssignment.Application.Featuers.ReservationFeatuers.Queries;

namespace NokoodAssignment.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReservationController : NokoodControllerBase<ReservationController>
    {
        public ReservationController(ILogger<ReservationController> logger, IMediator mediator, ICurrentUser currentUser) : base(logger, mediator, currentUser)
        {
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAsync([FromRoute]GetReservationByIdQuery query)
        {
            var queryResults = await Mediator.Send(query);
            return queryResults.Success ? Ok(queryResults) : BadRequest(queryResults);
        }

        [HttpGet()]
        public async Task<IActionResult> GetListAsync([FromQuery] GetReservationListQuery query)
        {
            var queryResults = await Mediator.Send(query);
            return queryResults.Success ? Ok(queryResults) : BadRequest(queryResults);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody]CreateReservationCommand command)
        {
            var commandResults = await Mediator.Send(command);
            return commandResults.Success ? Created("",commandResults) : BadRequest(commandResults);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateReservationCommand command)
        {
            var commandResults = await Mediator.Send(command);
            return commandResults.Success ? Ok(commandResults) : BadRequest(commandResults);
        }


        [HttpDelete()]
        public async Task<IActionResult> UpdateAsync([FromQuery] DeleteReservationCommand command)
        {
            var commandResults = await Mediator.Send(command);
            return commandResults ? NoContent() : BadRequest();
        }
    }
}
