using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.BankApp.Domain.Entities
{
    public  class Card
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool Status { get; set; }
        public CardType Type { get; set; }
        public Account Account { get; set; }
    }
}
