namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial amount : ");
            int amount = int.Parse(Console.ReadLine());
            IBankAccount account = new BankAccountProxy(new RealBankAccount(amount));

            account.Deposit(100000);
            account.Withdraw(50000);

            decimal balance = account.GetBalance();
            Console.WriteLine($"Current balance: ${balance}");
        }
    }
}