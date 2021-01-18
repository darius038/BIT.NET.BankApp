using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BIT.NET.BankApp.Domain.Entities
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}