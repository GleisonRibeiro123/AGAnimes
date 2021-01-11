using Application.Interfaces;
using AutoMapper;
using Data.Requests;
using Domain.Models;
using Domain.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppServices
{
    public class AnimeAppService : IAnimeAppService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public AnimeAppService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public FindAnimesResult FindAnimes(FindAnimesRequest request)
        {
            var response = _mediator.Send(request).GetAwaiter().GetResult();
            return response;
        }
    }
}
