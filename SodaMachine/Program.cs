using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            //Console.WriteLine("Please select a soda\n1:Orange soda\n2:Grape soda\n3:Lemon soda");
            //Console.ReadLine();
            machine.MachineSelection();
            //Console.WriteLine("Please enter in the ammount of money");
            //machine.ChangeCalculator(Convert.ToDouble(Console.ReadLine()));
        }
    }
}
