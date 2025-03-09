using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Application.Interfaces;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IApplicationDbContext _context;

        public ProductsController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] // ✅ Certifique-se de que esse atributo está presente
        public IActionResult GetProducts()
        {
            return Ok(_context.Products);
        }

        [HttpPost] // ✅ Garante que o método POST está correto
        public IActionResult CreateProduct([FromBody] Product product)
        {
            _context.Products.Add(product);
            return Ok(product);
        }
    }
}
