using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalDBWebApiUsingEF.Data;
using LocalDBWebApiUsingEF.Models;


namespace LocalDBWebApiUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DBManager _context;

        public UsersController(DBManager context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetUserByEmail), new { email = user.Email }, user);
            }
            catch (DbUpdateException)
            {
                return BadRequest("User already exists with this username.");
            }
        }

        // GET: api/Users/{entry}
        [HttpGet("{entry}")]
        public async Task<ActionResult<User>> GetUserByEmail(string entry)
        {
            // If user searches via email
            if (entry.Contains("@"))
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == entry);
                if (user == null)
                {
                    return NotFound("User not found.");
                }
                return user;
            }
            // If user searches by username
            else
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == entry);
                if (user == null)
                {
                    return NotFound("User not found.");
                }
                return user;
            }
        }

        // PUT: api/Users/{username}
        [HttpPut("{username}")]
        public async Task<IActionResult> UpdateUserProfile(string username, User updatedUser)
        {
            var existingUser = await _context.Users.FindAsync(username);
            if (existingUser == null)
            {
                return NotFound("User not found.");
            }

            // Update properties
            existingUser.Name = updatedUser.Name;
            existingUser.Email = updatedUser.Email;
            existingUser.Address = updatedUser.Address;
            existingUser.Phone = updatedUser.Phone;
            existingUser.Password = updatedUser.Password;
            existingUser.Picture = updatedUser.Picture;

            _context.Entry(existingUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Users.Any(e => e.Username == username))
                {
                    return NotFound("User not found.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // DELETE: api/Users/{username}
        [HttpDelete("{username}")]
        public async Task<IActionResult> DeleteUser(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null)
            {
                return NotFound("User not found.");
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
