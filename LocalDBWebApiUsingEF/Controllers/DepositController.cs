using LocalDBWebApiUsingEF.Data;
using LocalDBWebApiUsingEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalDBWebApiUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly DBManager _context;

        public DepositController(DBManager context)
        {
            _context = context;
        }
        // POST: api/deposit
        [HttpPost]
        public async Task<ActionResult<BankAccount>> ProcessDeposit(Transaction transact)
        {
            var account = await _context.BankAccounts
                                     .FirstOrDefaultAsync(b => b.AccountNumber == transact.AccountNumber);
            if (account == null)
            {
                return NotFound();
            }
            account.Balance = account.Balance + transact.Amount;
            account.Transactions.Add(transact);
            _context.Entry(account).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.BankAccounts.Any(e => e.AccountNumber == transact.AccountNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();

            // _context.BankAccounts.Add(account);
            // await _context.SaveChangesAsync();
            // return CreatedAtAction(nameof(GetBankAccount), new { id = account.AccountNumber }, account);
        }
    }
}
