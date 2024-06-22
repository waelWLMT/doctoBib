using AutoMapper;
using BLL.UseCases.Queries.RendezVousQueries;
using Core.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RendezVousController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public RendezVousController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("GetCurrentWeekRdvs")]
        public async Task<List<RendezVousReadDto>> GetCurrentWeekRdvs(int idPraticien)
        {
            var request = new GetCurrentWeekRdvsRequest()
            {
                IdPraticien = idPraticien
                
            };

            var rdvs = await _mediator.Send(request);

            var result = _mapper.Map<List<RendezVousReadDto>>(rdvs);

            return result;
        }


        [HttpGet("GetAllRdvPraticienByDates")]
        public async Task<List<RendezVousReadDto>> GetAllRdvPraticienByDates(int idPraticien, DateTime dateDebut,DateTime dateFin)
        {
            var request = new GetAllRdvPraticienByDatesRequest()
            {
                IdPraticien = idPraticien,
                DateDebut = dateDebut,
                DateFin = dateFin                
            };

            var rdvs = await _mediator.Send(request);

            var result = _mapper.Map<List<RendezVousReadDto>>(rdvs);

            return result;
        }

    }
}
