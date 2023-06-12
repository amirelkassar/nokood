using MediatR;
using Microsoft.AspNetCore.Mvc;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Dots;

namespace NokoodAssignment.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : NokoodControllerBase<AccountController>
    {
        private readonly IAuthenticationService authenticationService;

        public AccountController(ILogger<AccountController> logger, IMediator mediator, ICurrentUser currentUser, IAuthenticationService authenticationService) : base(logger, mediator, currentUser)
        {
            this.authenticationService = authenticationService;
        }

        [HttpPost("Login")]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> LoginAsync([FromBody] LoginDto input)
        {
            var results = await authenticationService.LoginAsync(input);
            if (results.Success)
            {
                return Created("", new ApiResponse<UserTokenDto>
                {
                    Success = true,
                    Code = 204,
                    Message = "Token Generated",
                    Data = results
                });
            }
            else
            {
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Code = 400,
                    Error = "Couldn't generate the token",
                    Message = "Invalid username or password"
                });
            }
        }
    }
}
