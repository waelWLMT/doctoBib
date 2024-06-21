using AutoMapper;
using BLL.Services.ReadServices;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleReadService _readRoleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleReadService readRoleService, IMapper mapper)
        {
            _readRoleService = readRoleService;
            _mapper = mapper;
        }

        [HttpGet("GetAllRoles")]
        public List<Role> GetAllRoles()
        {
            var roles = _readRoleService.GetAll();

            var result = _mapper.Map<List<Role>>(roles);

            return result;
        }



    }
}
