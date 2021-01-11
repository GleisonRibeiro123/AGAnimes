using Data.Requests;
using Domain.Models;
using Domain.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AnimesRepository : IRequestHandler<FindAnimesRequest, FindAnimesResult>
    {

        public Task<FindAnimesResult> Handle(FindAnimesRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new FindAnimesResult());
        }
    }
}
