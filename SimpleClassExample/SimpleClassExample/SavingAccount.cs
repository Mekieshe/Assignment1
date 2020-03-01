﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class SavingAccount
    {
        public double currBalance;
        public SavingAccount(double balance)
        {
            currBalance = balance;
        }
        public static double currInterestRate = 0.04;
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetInterestRate()
        { return currInterestRate; }
    }
}
