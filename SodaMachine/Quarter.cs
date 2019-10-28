using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine 
{
    public class Quarter : Machine
    {
        private double quarterCost;

        public double QuarterCost 
        {
            get
            {
                return quarterCost;
            }
            set
            {
                value = quarterCost;
            }
        }
        public Quarter()
        {
            quarterCost = 0.25;
        }
    }
}
