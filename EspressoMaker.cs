using Kaffemaskine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    // Class for making espresso
    public class EspressoMaker : BeverageMaker
    {
        // Property for the amount of coffee beans
        public double CoffeeBeans { get; private set; }

        // Add the specified amount of coffee beans
        public override void AddIngredients(double amount)
        {
            CoffeeBeans += amount;
            Console.WriteLine("Adding coffee beans...");
        }

        // Get the name of the beverage
        public override string BeverageName => "espresso";

        // Get the required water amount for a single serving of espresso
        public override int RequiredWaterAmount => 30; // 30ml for a single shot of espresso
    }

}
