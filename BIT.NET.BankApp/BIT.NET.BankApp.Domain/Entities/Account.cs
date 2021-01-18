using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BIT.NET.BankApp.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }
        
        public ICollection<Card> Cards { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
