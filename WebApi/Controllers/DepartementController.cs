using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IMediator _mediator;

        public DepartementController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }


        [HttpGet]
        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
