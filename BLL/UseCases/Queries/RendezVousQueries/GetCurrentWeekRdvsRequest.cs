using Core.Dtos;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.RendezVousQueries
{
    public class GetCurrentWeekRdvsRequest : IRequest<List<RendezVous>>
    {
        public int IdPraticien { get; set; }
    }
}
