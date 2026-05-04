
using FinanceControl.Domain.Enums;

namespace FinanceControl.Application.DTOs.Transaction
{
    public class CreateTransactionDto
    {
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public string Category { get; set; }
    }
}
