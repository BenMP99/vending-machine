﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine
{
    interface IPaymentIn
    {
        void TakePayment(BalanceSystem balanceSystem);
    }
}
