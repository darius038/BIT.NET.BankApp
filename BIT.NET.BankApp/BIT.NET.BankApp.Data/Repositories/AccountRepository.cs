using BIT.NET.BankApp.Data.Context;
using BIT.NET.BankApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIT.NET.BankApp.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateAccount(User appUser)
        {
            Random random = new Random();
           
            var ibanNo = "LT60 1010 0123 4567 "+ random.Next(1000, 9999);
            var account = new Account() {User= appUser, IBAN = ibanNo};
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public List<Account> GetAccounts(string userId)
        {
            return _context.Accounts.Where(a => a.User.Id == userId).ToList();
        }
    }
}
