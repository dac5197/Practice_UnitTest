using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_UnitTest.ApplicationCore.Models;
using Practice_UnitTest.Infrastructure.Services.CommandServices;
using Practice_UnitTest.Infrastructure.Services.QueryServices;
using Practice_UnitTest.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_UnitTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DacmeTcgCardController : ControllerBase
    {
        private readonly IDacmeTcgCardCommandService _dacmeTcgCardCommandService;
        private readonly IDacmeTcgCardQueryService _dacmeTcgCardQueryService;

        public DacmeTcgCardController(IDacmeTcgCardCommandService dacmeTcgCardCommandService,
                                      IDacmeTcgCardQueryService dacmeTcgCardQueryService)
        {
            _dacmeTcgCardCommandService = dacmeTcgCardCommandService;
            _dacmeTcgCardQueryService = dacmeTcgCardQueryService;
        }

        // GET: api/<DacmeTcgCardController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var output = await _dacmeTcgCardQueryService.GetAsync();
            return Ok(output);
        }

        // GET: api/<DacmeTcgCardController>/guid
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var output = await _dacmeTcgCardQueryService.GetAsync(id);
            return output is not null ? Ok(output) : NotFound();
        }

        // POST: api/<DacmeTcgCardController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DacmeTcgCardVm value)
        {
            DacmeTcgCard card = new()
            {
                Id = Guid.NewGuid(),
                Name = value.Name,
                CastingCostValue = value.CastingCostValue,
                Color = value.Color,
                Type = value.Type
            };

            var output = await _dacmeTcgCardCommandService.CreateAsync(card);

            return Ok(output);
        }
    }
}
