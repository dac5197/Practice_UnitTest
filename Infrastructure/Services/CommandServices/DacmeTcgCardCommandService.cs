using Practice_UnitTest.ApplicationCore.Models;
using Practice_UnitTest.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_UnitTest.Infrastructure.Services.CommandServices
{
    public class DacmeTcgCardCommandService : IDacmeTcgCardCommandService
    {
        private readonly ApplicationDbContext _context;

        public DacmeTcgCardCommandService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DacmeTcgCard> CreateAsync(DacmeTcgCard card)
        {
            await _context.AddAsync(card);
            await _context.SaveChangesAsync();
            return card;
        }
    }
}
