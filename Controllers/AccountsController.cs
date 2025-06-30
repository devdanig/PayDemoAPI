using Microsoft.AspNetCore.Mvc;
using PayDemoAPI.Data;
using PayDemoAPI.Models;

namespace PayDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AccountsController(AppDbContext context) => _context = context;

        // GET /api/accounts
        [HttpGet]
        public IActionResult GetAccounts() => Ok(_context.Accounts.ToList());

        // POST /api/accounts
        [HttpPost]
        public IActionResult CreateAccount([FromBody] Account account)
        {
            // Validar que exista el usuario
            var userExists = _context.Users.Any(u => u.Id == account.UserId);
            if (!userExists)
                return BadRequest($"No existe el usuario con ID {account.UserId}");

            _context.Accounts.Add(account);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAccounts), new { id = account.Id }, account);
        }

        // POST /api/accounts/transfer
            [HttpPost("transfer")]
            public IActionResult Transfer([FromBody] TransferRequest request)
            {
                // Busca las cuentas de origen y destino
                var sourceAccount = _context.Accounts.FirstOrDefault(a => a.Id == request.SourceAccountId);
                var destinationAccount = _context.Accounts.FirstOrDefault(a => a.Id == request.DestinationAccountId);

                if (sourceAccount == null || destinationAccount == null)
                    return NotFound("Cuenta de origen o destino no encontrada");

                if (sourceAccount.Balance < request.Amount)
                    return BadRequest("Saldo insuficiente en la cuenta de origen");

                // Realiza la transacción
                sourceAccount.Balance -= request.Amount;
                destinationAccount.Balance += request.Amount;

                _context.SaveChanges();

                return Ok(new { message = "Transferencia realizada con éxito" });
            }
    }
}
