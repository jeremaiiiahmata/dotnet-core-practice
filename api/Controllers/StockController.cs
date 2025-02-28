using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Data;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet] //same as [HttpRead]
        public IActionResult GetAll()
        {
            var stocks = _context.Stocks.ToList();

            return Ok(stocks);
        }

        [HttpGet("{id}")] 
        public IActionResult GetByID([FromRoute] int id)
        {
            var stock = _context.Stocks.Find(id);

            if (stock == null){ //if there is no stock found, return not found.
                return NotFound();
            }

            return Ok(stock);
        }
    }
}