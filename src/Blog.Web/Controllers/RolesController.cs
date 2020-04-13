﻿using System.Threading;
using System.Threading.Tasks;
using Blog.Services.Roles;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public RolesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("roles")]
        public async Task<ActionResult<GetRolesResult>> GetRoles(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetRolesRequest(), cancellationToken);
        }
    }
}