using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class BankAccountProxy : IBankAccount
    {
        private IBankAccount _account;

        public BankAccountProxy(IBankAccount bankAccount)
        {
            _account = bankAccount;
        }

        /*private IBankAccount GetRealAccount()
        {
            if (_account == null)
            {
                _account = new RealBankAccount(_initialBalance);
            }
            return _account;
        }*/

        public void Deposit(decimal amount)
        {
            _account.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            _account.Withdraw(amount);
        }

        public decimal GetBalance()
        {
            return _account.GetBalance();
        }
    }
}
