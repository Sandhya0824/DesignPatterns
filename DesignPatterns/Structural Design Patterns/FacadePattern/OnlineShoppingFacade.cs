using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class OnlineShoppingFacade
    {
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly IInventoryService _inventoryService;

        public OnlineShoppingFacade(IOrderService orderService, IPaymentService paymentService, IInventoryService inventoryService)
        {
            _orderService = orderService;
            _paymentService = paymentService;
            _inventoryService = inventoryService;
        }

        public void CompleteOrder()
        {
            Console.WriteLine("Starting online shopping...");
            _orderService.PlaceOrder();
            _paymentService.ProcessPayment();
            _inventoryService.UpdateInventory();
            Console.WriteLine("Online shopping completed.");
        }
    }
}
