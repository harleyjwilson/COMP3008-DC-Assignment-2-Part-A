using LocalDBWebApiUsingEF.Data;
using Microsoft.AspNetCore.Mvc;

namespace LocalDBWebApiUsingEF.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DepositController : ControllerBase {
        private readonly DBManager _context;

        public DepositController(DBManager context) {
            _context = context;
        }

    }
}