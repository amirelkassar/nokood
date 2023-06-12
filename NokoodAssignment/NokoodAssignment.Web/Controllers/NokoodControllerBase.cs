using MediatR;
using Microsoft.AspNetCore.Mvc;
using NokoodAssignment.Application.Base;

namespace NokoodAssignment.Web.Controllers
{
    public abstract class NokoodControllerBase<TController> : ControllerBase where TController : NokoodControllerBase<TController>
    {
        public NokoodControllerBase(ILogger<TController> logger,IMediator mediator,ICurrentUser currentUser)
        {
            Logger = logger;
            Mediator = mediator;
            CurrentUser = currentUser;
        }

        public ILogger<TController> Logger { get; }
        public IMediator Mediator { get; }
        public ICurrentUser CurrentUser { get; }
    }
}
