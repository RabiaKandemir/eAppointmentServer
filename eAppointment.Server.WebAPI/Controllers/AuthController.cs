using eAppointment.Server.WebAPI.Abstractions;
using eAppointmentServer.Application.Features.Auth.Login;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace eAppointment.Server.WebAPI.Controllers
{
    public sealed class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginCommand request,CancellationToken cancellationToken)
        {
            var response=await _mediator.Send(request,cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
