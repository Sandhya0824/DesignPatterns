using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ExpenseHandlerChainBuilder
    {
        public static IExpenseHandler BuildExpenseHandlerChain()
        {
            var managerHandler = new ManagerExpenseHandler();
            var directorHandler = new VPExpenseHandler();
            var cfoHandler = new CMOExpenseHandler();

            managerHandler.SetNextHandler(directorHandler);
            directorHandler.SetNextHandler(cfoHandler);

            return managerHandler;
        }
    }
}
