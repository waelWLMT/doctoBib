﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PraticienController : ControllerBase
    {
        private readonly IMediator _mediator;
        private IMapper _mapper;

        public PraticienController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
