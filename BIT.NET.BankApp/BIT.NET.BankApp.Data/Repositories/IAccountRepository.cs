using BIT.NET.BankApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.BankApp.Data.Repositories
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts(string userId);
        void CreateAccount(User appUser);

    }
}
