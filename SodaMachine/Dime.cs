using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Dime : Machine
    {
        private double dimeCost;

        public double DimeCost 
        {
            get
            {
                return dimeCost;
            }
            set
            {
                value = dimeCost;
            } 
        }
        public Dime()
        {
            dimeCost = 0.10;
        }
    }
}
