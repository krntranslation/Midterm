using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Customer
    {

        private double wallet;

        public double  Wallet 
        {
            get
            {
                return wallet;
            }
            set
            {
                value = wallet;
            } 
        }


        public Customer()
        {
            wallet = 2.50;
        }

    }
}
