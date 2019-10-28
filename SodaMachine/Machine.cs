using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Machine
    {
        private double quarters;
        private double dimes;
        private double nickles;
        private double pennys;
        private double costOfGrape;
        private double costOfOrange;
        private double costOfLemon;

        public int cans;
        public double insertedMoney;
        public double change;

        public double CostOfGrape
        {
            get
            {
                return costOfGrape;
            }
            set
            {
                value = costOfGrape;
            }
        }
        public double CostOfOrange
        {
            get
            {
                return costOfOrange;
            }
            set
            {
                value = costOfOrange;
            }
        }
        public double CostOfLemon
        {
            get
            {
                return costOfLemon;
            }
            set
            {
                value = costOfLemon;
            }
        }

        public double machineTotal;
        public double canSelection;

        public Machine()
        {
            cans = 30;
            quarters = 20;
            dimes = 10;
            nickles = 20;
            pennys = 50;
            costOfLemon = 0.06;
            costOfOrange = 0.60;
            costOfGrape = 0.35;
            machineTotal = (quarters * 0.25) + (dimes * 0.10) + (nickles * 0.05) + (pennys * 0.01);
            insertedMoney = 0.00;
            this.change = 0.00;

        }
        public void MachineSelection()
        {
            Console.WriteLine("Please select a soda\n1:Orange soda\n2:Grape soda\n3:Lemon soda");
            canSelection = Convert.ToInt32(Console.ReadLine());
            switch (canSelection)
            {
                case 1:
                    Console.WriteLine("You choosen Orange, the cost of Orange soda is 0.60, please enter in how much you put into the machine");
                    insertedMoney = Convert.ToDouble(Console.ReadLine());
                    cans--;
                    
                    if (insertedMoney >= 0.60)
                    {
                        change = insertedMoney - 0.60;
                        machineTotal -= insertedMoney;
                        ChangeCalculator(change);
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough money");
                    }
                    return;
                case 2:
                    Console.WriteLine("You choosen Grape, the cost of Grape soda is 0.35, please enter in how much you put into the machine");
                    cans--;
                    insertedMoney = Convert.ToDouble(Console.ReadLine());
                    if (insertedMoney >= 0.35)
                    {
                        change = insertedMoney - 0.35;
                        machineTotal -= insertedMoney;
                        ChangeCalculator(change);
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough money");
                    }
                    return;
                case 3:
                    Console.WriteLine("You choosen Lemon, the cost of Lemon is 0.06,  please enter in how much you put into the machine");
                    cans--;
                    insertedMoney = Convert.ToDouble(Console.ReadLine());
                    if (insertedMoney >= 0.06)
                    {
                        change = insertedMoney - 0.06;
                        machineTotal -= insertedMoney;
                        ChangeCalculator(change);
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough money,  please enter in how much you put into the machine");
                    }
                    return;
                default:
                    break;
            }
        }
        public void ChangeCalculator(double change)
        {

            double Quarters = (double)(change / .25);
            change %= .25;

            double Dimes = (double)(change / .10);
            change %= .10;

            double Nickles = (double)(change / .05);
            change %= .05;

            double Pennies = (double)(change / .01);

            Console.WriteLine($"Your change is {Quarters} quarters, {Dimes} dimes, {Nickles} nickles, {Pennies} pennies.");

            Console.ReadLine();
        }




    }

}
