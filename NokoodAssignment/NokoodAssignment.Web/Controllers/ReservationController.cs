using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Featuers.ReservationFeatuers.Commands;

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

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateReservationCommand command)
        {
            var commandResults = await Mediator.Send(command);
            return commandResults.Success ? Ok(commandResults) : BadRequest(commandResults);
        }
    }
}
