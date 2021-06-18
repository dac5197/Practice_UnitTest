using Practice_UnitTest.ApplicationCore.Models;
using System.Threading.Tasks;

namespace Practice_UnitTest.Infrastructure.Services.CommandServices
{
    public interface IDacmeTcgCardCommandService
    {
        Task<DacmeTcgCard> CreateAsync(DacmeTcgCard card);
    }
}