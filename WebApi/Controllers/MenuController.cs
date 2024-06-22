using AutoMapper;
using BLL.UseCases.Queries.MenuQueries;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    /// <summary>
    /// The menu controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        /// <summary>
        /// The mediator.
        /// </summary>
        private readonly IMediator _mediator;
        /// <summary>
        /// The mapper.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="mapper">The mapper.</param>
        public MenuController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        /// <summary>
        /// Get all menu.
        /// </summary>
        /// <returns><![CDATA[List<MenuReadDto>]]></returns>
        [HttpGet]
        public async Task<List<MenuReadDto>> GetAllMenu()
        {
            var menus = await _mediator.Send(new GetAllMenuRequest());
            var result = _mapper.Map<List<MenuReadDto>>(menus);

            return result;
        }
    }
}
