﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IBlackCoffee
    {
        double GetCost();
        string GetDescription();
        IBlackCoffee Add(CoffeeDecorator decorator);
    }
}
