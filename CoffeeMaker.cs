using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    // Class for making coffee
    public class CoffeeMaker : BeverageMaker
    {
        // Property for the amount of coffee beans
        public double CoffeeBeans { get; private set; }

        // Add the specified amount of coffee beans
        public override void AddIngredients(double amount)
        {
            CoffeeBeans += amount;
        }

        // Get the name of the beverage
        public override string BeverageName => "coffee";

        // Get the required water amount for a single serving of coffee
        public override int RequiredWaterAmount => 250; // 250ml for a regular cup of coffee
    }
}
