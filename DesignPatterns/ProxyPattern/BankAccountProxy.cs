using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class BankAccountProxy : IBankAccount
    {
        private RealBankAccount _realAccount;
        private decimal _initialBalance;

        public BankAccountProxy(decimal initialBalance)
        {
            _initialBalance = initialBalance;
        }

        private RealBankAccount GetRealAccount()
        {
            if (_realAccount == null)
            {
                _realAccount = new RealBankAccount(_initialBalance);
            }
            return _realAccount;
        }

        public void Deposit(decimal amount)
        {
            GetRealAccount().Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            GetRealAccount().Withdraw(amount);
        }

        public decimal GetBalance()
        {
            return GetRealAccount().GetBalance();
        }
    }
}
