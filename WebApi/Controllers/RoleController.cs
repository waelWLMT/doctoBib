using AutoMapper;
using BLL.Services.ReadServices;
using BLL.UseCases.Queries.RoleQueries;
using Core.Dtos;
using Core.Models;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {       
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public RoleController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        
        [HttpGet("GetAllRoles")]
        public List<RoleReadDto> GetAllRoles()
        {
            var roles = _mediator.Send(new GetAllRoleRequest());
            var result = _mapper.Map<List<RoleReadDto>>(roles);

            return result;
        }



    }
}
