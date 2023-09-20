namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var onlineShopping = new OnlineShoppingFacade(new OrderService(),new PaymentService(),new InventoryService());
            onlineShopping.CompleteOrder();
        }
    }
}