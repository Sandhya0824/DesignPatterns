﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public interface IExpenseHandler
    {
        void ApproveExpense(Expense expense);
    }
}
