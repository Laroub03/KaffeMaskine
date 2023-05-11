using System;


namespace Kaffemaskine
{
    public class Program
    {
        public static void Main()
        {
            Machine machine = new Machine();

            // Add initial water
            machine.AddWater(500);

            // Making coffee
            CoffeeMaker coffeeMaker = new CoffeeMaker();
            coffeeMaker.AddIngredients(50);
            machine.InsertBeverageMaker(coffeeMaker);
            machine.TurnOn();
            machine.TurnOff();

            Console.WriteLine("");

            // Making tea
            TeaMaker teaMaker = new TeaMaker();
            teaMaker.AddIngredients(40);
            machine.InsertBeverageMaker(teaMaker);
            machine.TurnOn();
            machine.TurnOff();

            Console.WriteLine("");

            // Adding more water for espresso
            machine.AddWater(30);

            // Making espresso
            EspressoMaker espressoMaker = new EspressoMaker();
            espressoMaker.AddIngredients(18); 
            machine.InsertBeverageMaker(espressoMaker);
            machine.TurnOn();
            machine.TurnOff();
        
        }
    }
}