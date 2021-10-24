using System;

namespace grandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            double totalQuantity = 0;
            double averageGradus=0;
            double gradusi = 0;

            for (int i = 1; i <= numberOfDays; i++)
            {
                double litersOfRakia = double.Parse(Console.ReadLine());
                totalQuantity += litersOfRakia;
                double gradus = double.Parse(Console.ReadLine());
                gradusi += gradus *litersOfRakia;
                averageGradus = gradusi / totalQuantity;

            }
            
            Console.WriteLine($"Liter: {totalQuantity:f2}");
            Console.WriteLine($"Degrees: {averageGradus:f2}");
            if (averageGradus < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageGradus >= 38 && averageGradus <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageGradus > 42) 
            {
                Console.WriteLine("Dilution with distilled water!");
            }


        }
    }
}
