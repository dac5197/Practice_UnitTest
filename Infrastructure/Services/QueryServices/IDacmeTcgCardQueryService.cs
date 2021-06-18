using Practice_UnitTest.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice_UnitTest.Infrastructure.Services.QueryServices
{
    public interface IDacmeTcgCardQueryService
    {
        Task<List<DacmeTcgCard>> GetAsync();
        Task<DacmeTcgCard> GetAsync(Guid id);
    }
}