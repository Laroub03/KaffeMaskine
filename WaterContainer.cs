using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    // Class to represent a water container
    public class WaterContainer
    {
        // Property for the amount of water
        public int WaterAmount { get; private set; }

        // Add the specified amount of water, and optionally print the message
        public void AddWater(int amount, bool fromTurnOn = false)
        {
            WaterAmount += amount;
            if (!fromTurnOn)
            {
                Console.WriteLine("Adding water...");
            }
        }
    }
}
