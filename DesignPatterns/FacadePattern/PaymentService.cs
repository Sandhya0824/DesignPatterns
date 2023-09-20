using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class PaymentService : IPaymentService
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed.");
        }
    }
}
