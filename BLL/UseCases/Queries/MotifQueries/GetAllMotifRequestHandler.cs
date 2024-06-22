using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.MotifQueries
{
    public class GetAllMotifRequestHandler : IRequestHandler<GetAllMotifRequest, List<Motif>>
    {
        private readonly IMotifReadService _readService;

        public GetAllMotifRequestHandler(IMotifReadService readService)
        {
            _readService = readService;
        }
        public async Task<List<Motif>> Handle(GetAllMotifRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetAllAsync();
        }
    }
}
