using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Penny : Machine
    {
        private double pennyCost;
        public double PennyCost 
        { 
            get
            {
                return pennyCost;
            }
            set
            {
                pennyCost = value;
            }
                }
        
        
        public Penny()
        {
            pennyCost = 0.01;
        }
    }
}
