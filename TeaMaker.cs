using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    // Class for making tea
    public class TeaMaker : BeverageMaker
    {
        // Property for the amount of tea leaves
        public double TeaLeaves { get; private set; }

        // Add the specified amount of tea leaves
        public override void AddIngredients(double amount)
        {
            TeaLeaves += amount;
        }

        // Get the name of the beverage
        public override string BeverageName => "tea";

        // Get the required water amount for a single serving of tea
        public override int RequiredWaterAmount => 250; // 250ml for a regular cup of tea
    }

}

