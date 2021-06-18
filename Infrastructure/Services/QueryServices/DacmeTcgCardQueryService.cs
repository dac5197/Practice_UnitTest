using Microsoft.EntityFrameworkCore;
using Practice_UnitTest.ApplicationCore.Models;
using Practice_UnitTest.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_UnitTest.Infrastructure.Services.QueryServices
{
    public class DacmeTcgCardQueryService : IDacmeTcgCardQueryService
    {
        private readonly ApplicationDbContext _context;

        public DacmeTcgCardQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DacmeTcgCard>> GetAsync()
        {
            var output = await _context.DacmeTcgCards.ToListAsync();
            return output;
        }

        public async Task<DacmeTcgCard> GetAsync(Guid id)
        {
            var output = await _context.DacmeTcgCards.FindAsync(id);
            return output;
        }
    }
}
