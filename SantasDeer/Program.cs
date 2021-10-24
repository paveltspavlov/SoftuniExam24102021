using System;

namespace SantasDeer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double foodPerDayDeer1 = double.Parse(Console.ReadLine());
            double foodPerDayDeer2 = double.Parse(Console.ReadLine());
            double foodPerDayDeer3 = double.Parse(Console.ReadLine());
            double result;
            double totalFoodNeeded;

            totalFoodNeeded = (foodPerDayDeer1 * numberOfDays) + (foodPerDayDeer2 * numberOfDays) + (foodPerDayDeer3 * numberOfDays);
            
            if (totalFoodNeeded < foodLeftKg)
            {
                
                result = Math.Floor(foodLeftKg - totalFoodNeeded);
                
                Console.WriteLine($"{result} kilos of food left.");
            }
            else 
            {
                
                result = Math.Ceiling(totalFoodNeeded - foodLeftKg);
                
                Console.WriteLine($"{result} more kilos of food are needed.");
            }
        }
    }
}
