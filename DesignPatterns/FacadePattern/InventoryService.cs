﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class InventoryService : IInventoryService
    {
        public void UpdateInventory()
        {
            Console.WriteLine("Inventory updated.");
        }
    }
}
