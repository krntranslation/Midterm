using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{

    public class Nickle : Machine
    {
        private double nickleCost;

        public double NickleCost
        {
            get
            {
                return nickleCost;
            }
            set
            {
                value = nickleCost;
            }
        }
        public Nickle()
        {
            nickleCost = 0.05;
        }

    }

}
