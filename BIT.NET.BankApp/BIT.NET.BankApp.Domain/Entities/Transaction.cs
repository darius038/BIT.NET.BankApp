using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIT.NET.BankApp.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public string Details { get; set; }
        public TransactionType Type { get; set; }

    }
}