using BLL.Services.Usefull;
using BLL.Services.WriteServices;
using BLL.Services.WriteServices.Impl;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Commands.CalendrierCmd
{
    /// <summary>
    /// The create calendrier command handler.
    /// </summary>
    public class CreateCalendrierCommandHandler : IRequestHandler<CreateCalendrierCommand, Calendrier>
    {
        /// <summary>
        /// The calendrier service.
        /// </summary>
        private readonly ICalendrierService _calendrierService;
        /// <summary>
        /// The builder.
        /// </summary>
        private readonly ICalendrierBuilder _builder;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCalendrierCommandHandler"/> class.
        /// </summary>
        /// <param name="calendrierService">The calendrier service.</param>
        /// <param name="builder">The builder.</param>
        public CreateCalendrierCommandHandler(ICalendrierService calendrierService, ICalendrierBuilder builder)
        {
            _calendrierService = calendrierService;
            _builder = builder;
        }

        /// <summary>
        /// Handle and return a task of type calendrier.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<Calendrier>]]></returns>
        public async Task<Calendrier> Handle(CreateCalendrierCommand request, CancellationToken cancellationToken)
        {
            var calandrier = _builder.BuildFromCalendrierCmd(request);
            return await _calendrierService.InsertAsync(calandrier);  
        }
    }
}
