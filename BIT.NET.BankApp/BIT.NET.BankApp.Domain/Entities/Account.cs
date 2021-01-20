
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace BIT.NET.BankApp.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string IBAN { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }
        public User User { get; set; }
        public ICollection<Card> Cards { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
