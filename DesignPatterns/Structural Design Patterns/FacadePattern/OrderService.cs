﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class OrderService : IOrderService
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Order placed.");
        }
    }
}
