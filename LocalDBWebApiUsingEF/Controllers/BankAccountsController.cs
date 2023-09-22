using LocalDBWebApiUsingEF.Data;
using LocalDBWebApiUsingEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalDBWebApiUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly DBManager _context;

        public BankAccountsController(DBManager context)
        {
            _context = context;
        }

        // GET: api/BankAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankAccount>>> GetAllBankAccounts()
        {
            return await _context.BankAccounts.Include(b => b.User).ToListAsync();

        }

        // POST: api/BankAccounts
        [HttpPost]
        public async Task<ActionResult<BankAccount>> CreateBankAccount(BankAccount account)
        {
            _context.BankAccounts.Add(account);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBankAccount), new { id = account.AccountNumber }, account);
        }

        // GET: api/BankAccounts/12345
        [HttpGet("{accountNumber}")]
        public async Task<ActionResult<BankAccount>> GetBankAccount(int accountNumber)
        {
            var account = await _context.BankAccounts
                            .Include(b => b.User)
                            .FirstOrDefaultAsync(b => b.AccountNumber == accountNumber);

            if (account == null)
            {
                return NotFound();
            }
            return account;
        }

        // PUT: api/BankAccounts/12345
        [HttpPut("{accountNumber}")]
        public async Task<IActionResult> UpdateBankAccount(int accountNumber, BankAccount account)
        {
            if (accountNumber != account.AccountNumber)
            {
                return BadRequest();
            }
            _context.Entry(account).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.BankAccounts.Any(e => e.AccountNumber == accountNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // DELETE: api/BankAccounts/12345
        [HttpDelete("{accountNumber}")]
        public async Task<IActionResult> DeleteBankAccount(int accountNumber)
        {
            var account = await _context.BankAccounts.FindAsync(accountNumber);
            if (account == null)
            {
                return NotFound();
            }
            _context.BankAccounts.Remove(account);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
