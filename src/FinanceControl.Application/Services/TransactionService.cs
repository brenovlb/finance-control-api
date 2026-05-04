
using FinanceControl.Application.DTOs.Transaction;
using FinanceControl.Application.Interfaces;
using FinanceControl.Domain.Entities;

namespace FinanceControl.Application.Services
{
    public class TransactionService : ITransactionService
    {
        private static readonly List<Transaction> _transactions = new();

        public Task<Guid> CreateAsync(CreateTransactionDto dto)
        {
            var transaction = new Transaction(dto.Amount, dto.Type, dto.Category);

            _transactions.Add(transaction);

            return Task.FromResult(transaction.Id);
        }

        public Task<IEnumerable<Transaction>> GetAllAsync(int page, int pageSize)
        {
            var result = _transactions
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return Task.FromResult(result);
        }
    }
}
