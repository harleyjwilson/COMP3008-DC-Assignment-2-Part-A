using LocalDBWebApiUsingEF.Data;
using Microsoft.AspNetCore.Mvc;

namespace LocalDBWebApiUsingEF.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class WithdrawController : ControllerBase {
        private readonly DBManager _context;

        public WithdrawController(DBManager context) {
            _context = context;
        }
        // POST: api/deposit

    }
}