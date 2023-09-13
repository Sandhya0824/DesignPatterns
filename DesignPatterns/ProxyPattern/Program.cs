namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankAccount account = new BankAccountProxy(1000);

            account.Deposit(100000);
            account.Withdraw(50000);

            decimal balance = account.GetBalance();
            Console.WriteLine($"Current balance: ${balance}");
        }
    }
}