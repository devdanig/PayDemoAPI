using Microsoft.AspNetCore.Mvc;
using PayDemoAPI.Data;
using PayDemoAPI.Models;

namespace PayDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context) => _context = context;

        [HttpGet]
        public IActionResult GetUsers() => Ok(_context.Users.ToList());

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }
    }
}