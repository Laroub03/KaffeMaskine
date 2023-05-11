using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    // Class to represent a coffee machin
    public class Machine
    {
        public WaterContainer WaterContainer { get; set; }
        public BeverageMaker BeverageMaker { get; set; }
        public bool IsOn { get; private set; }

        public Machine()
        {
            WaterContainer = new WaterContainer();
            IsOn = false;
        }

        // Add the specified amount of water to the water container
        public void AddWater(int amount)
        {
            WaterContainer.AddWater(amount);
        }

        // Insert the specified beverage maker
        public void InsertBeverageMaker(BeverageMaker beverageMaker)
        {
            BeverageMaker = beverageMaker;
        }

        // Add the specified amount of ingredients to the beverage maker
        public void AddIngredients(double amount)
        {
            BeverageMaker.AddIngredients(amount);
        }

        // Turn on the coffee machine and make the selected beverage
        public void TurnOn()
        {
            if (WaterContainer.WaterAmount >= BeverageMaker.RequiredWaterAmount && BeverageMaker != null)
            {
                IsOn = true;
                // Subtract the required water amount for the selected beverage from the water container
                WaterContainer.AddWater(-BeverageMaker.RequiredWaterAmount, true);
                Console.WriteLine($"The coffee machine is on and making {BeverageMaker.BeverageName}.");
            }
            else
            {
                Console.WriteLine($"Please add at least {BeverageMaker.RequiredWaterAmount}ml of water and insert a beverage maker with ingredients.");
            }
        }

        // Turn off the coffee machine
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("The coffee machine is off.");
        }
    }
}
