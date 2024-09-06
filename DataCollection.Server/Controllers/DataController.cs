using Microsoft.AspNetCore.Mvc;
using DataCollection.Server.Data; // Ensure this is included
using DataCollection.Server.Models; // Ensure this is included
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataCollection.Server.Controllers

{
[ApiController]
[Route("api/[controller]")]
public class ProductEntriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProductEntriesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<ProductEntry>> Get()
    {
        return await _context.ProductEntries.ToListAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Post(ProductEntry productEntry)
    {
        _context.ProductEntries.Add(productEntry);
        await _context.SaveChangesAsync();
        return Ok(productEntry);
    }
}
}