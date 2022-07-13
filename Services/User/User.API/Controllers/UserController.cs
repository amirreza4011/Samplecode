using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ordering.Application.Commands;
using Ordering.Application.Queries;
using Ordering.Application.Response;
using Ordering.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            //دیپندنسی کردن 
            _mediator = mediator;
        }

        /// <summary>
        /// دریافت لیست تمامی یوزرها
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<List<user>> Get()
        {
            return await _mediator.Send(new GetAllUserQuery());
        }

       


  

    }
}
