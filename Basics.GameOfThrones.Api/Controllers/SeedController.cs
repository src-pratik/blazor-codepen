using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basics.GameOfThrones.Data;
using Basics.GameOfThrones.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Basics.GameOfThrones.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly GameOfThronesDbContext _context;
        public SeedController(GameOfThronesDbContext dbContext)
        {
            _context = dbContext;
        }


        // GET: api/<SeedController>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            _context.Database.EnsureCreated();
            await _context.Houses.AddRangeAsync(SeedData.Houses);
            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}
