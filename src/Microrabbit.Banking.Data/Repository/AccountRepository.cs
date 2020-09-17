using Microrabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace Microrabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
