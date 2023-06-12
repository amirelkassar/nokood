using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NokoodAssignment.Application.Base;

namespace NokoodAssignment.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : NokoodControllerBase<ReservationController>
    {
        public ReservationController(ILogger<ReservationController> logger, IMediator mediator, ICurrentUser currentUser) : base(logger, mediator, currentUser)
        {
        }


    }
}
