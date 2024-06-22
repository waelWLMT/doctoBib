using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.PatientQueries
{
    public class GetAllPatientRequest : IRequest<List<Patient>>
    {
    }
}
