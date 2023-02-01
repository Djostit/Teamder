using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamderAPI.Data;
using TeamderAPI.Models;

namespace TeamderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("Authorization")]
        public async Task<ActionResult<User>> Authorization(User userr)
        {
            var user = await _context.User.SingleOrDefaultAsync(u => u.Username.Equals(userr.Username));
            if (user == null)
                return BadRequest("User not found");
            if (!BCrypt.Net.BCrypt.Verify(userr.Password, user.Password))
                return BadRequest("User not found");

            return Ok(user);
        }
        [HttpPost("AddUser")]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(await _context.User.ToListAsync());
        }
    }
}
