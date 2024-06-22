using AutoMapper;
using BLL.UseCases.Queries.MotifQueries;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    /// <summary>
    /// The motif controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MotifController : ControllerBase
    {
        /// <summary>
        /// The mediator.
        /// </summary>
        private readonly IMediator _mediator;
        /// <summary>
        /// The mapper.
        /// </summary>
        private IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="MotifController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="mapper">The mapper.</param>
        public MotifController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        /// <summary>
        /// Get all motif.
        /// </summary>
        /// <returns><![CDATA[Task<List<MotifReadDto>>]]></returns>
        [HttpGet("GetAllMotif")]
        public async Task<List<MotifReadDto>> GetAllMotif()
        {
            var request = new GetAllMotifRequest();
            var listMotifs = await _mediator.Send(request);
            var result = _mapper.Map<List<MotifReadDto>>(listMotifs);

            return result;
        }
    }
}
