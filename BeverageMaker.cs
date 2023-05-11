using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    // Abstract class for different types of beverage makers
    public abstract class BeverageMaker
    {
        // Add the specified amount of ingredients
        public abstract void AddIngredients(double amount);

        // Get the name of the beverage
        public abstract string BeverageName { get; }

        // Get the required water amount for a single serving of the beverage
        public abstract int RequiredWaterAmount { get; }
    }
}
