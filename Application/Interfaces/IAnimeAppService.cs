using Data.Requests;
using Domain.Models;
using Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAnimeAppService
    {
        FindAnimesResult FindAnimes(FindAnimesRequest request);
    }
}
