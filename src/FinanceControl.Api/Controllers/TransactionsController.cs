using FinanceControl.Application.DTOs.Transaction;
using FinanceControl.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers
{
    [ApiController]
    [Route("api/v1/transactions")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _service;

        public TransactionsController(ITransactionService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTransactionDto dto)
        {
            var id = await _service.CreateAsync(dto);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> Get(
                                    [FromQuery] int page = 1,
                                    [FromQuery] int pageSize = 10)
        {
            var result = await _service.GetAllAsync(page, pageSize);
            return Ok(result);
        }
    }
}
