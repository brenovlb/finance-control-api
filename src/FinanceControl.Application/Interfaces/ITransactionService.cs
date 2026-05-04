
using FinanceControl.Application.DTOs.Transaction;
using FinanceControl.Domain.Entities;

namespace FinanceControl.Application.Interfaces
{
    public interface ITransactionService
    {
        Task<Guid> CreateAsync(CreateTransactionDto dto);
        Task<IEnumerable<Transaction>> GetAllAsync(int page, int pageSize);
    }
}
