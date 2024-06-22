using AutoMapper;
using BLL.UseCases.Commands.CalendrierCmd;
using BLL.UseCases.Queries.CalendrierQueries;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    /// <summary>
    /// The calendrier controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CalendrierController : ControllerBase
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
        /// Initializes a new instance of the <see cref="CalendrierController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="mapper">The mapper.</param>
        public CalendrierController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Get by praticien id.
        /// </summary>
        /// <param name="praticienId">The praticien id.</param>
        /// <returns><![CDATA[Task<List<CalendrierReadDto>>]]></returns>
        [HttpGet("GetByPraticienId")]
        public async Task<List<CalendrierReadDto>> GetByPraticienId(int praticienId)
        {
            var query = new GetCalendrierByPraticienIdRequest() { PraticienId = praticienId };

            var calendriers = await _mediator.Send(query);

            return _mapper.Map<List<CalendrierReadDto>>(calendriers);
            
        }

        /// <summary>
        /// Get calendrier by id.
        /// </summary>
        /// <param name="idCalendrier">The id calendrier.</param>
        /// <returns><![CDATA[Task<CalendrierReadDto>]]></returns>
        [HttpGet("GetCalendrierById")]
        public async Task<CalendrierReadDto> GetCalendrierById(int idCalendrier)
        {
            var request = new GetCalendrierByIdRequest() { Id = idCalendrier };

            var calendrier = await _mediator.Send(request);

            return _mapper.Map<CalendrierReadDto>(calendrier);
        }


        /// <summary>
        /// Creates the calendrier.
        /// </summary>
        /// <param name="cmd">The cmd.</param>
        /// <returns><![CDATA[Task<object>]]></returns>
        [HttpPost("CreateCalendrier")]
        public async Task<object> CreateCalendrier(CreateCalendrierCommand cmd)
        {
            var calendrier = await _mediator.Send(cmd);
            var result = _mapper.Map<CalendrierReadDto>(calendrier);

            return result;
        }





    }
}
