
using FinanceControl.Domain.Enums;

namespace FinanceControl.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public decimal Amount { get; private set; }
        public TransactionType Type { get; private set; }
        public string Category { get; private set; }
        public DateTime Date { get; private set; }

        public Transaction(decimal amount, TransactionType type, string category)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Type = type;
            Category = category;
            Date = DateTime.UtcNow;
        }
    }
}
