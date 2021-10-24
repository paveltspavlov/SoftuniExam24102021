using System;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDancers = int.Parse(Console.ReadLine());
            double numberOfPoints = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string country = Console.ReadLine();
            double price;
            double expenses;
            double charity;
            double perDancer;

            if (country == "Bulgaria")
            {
                price = numberOfPoints * numberOfDancers;
            }
            else 
            {
                price = (numberOfPoints * numberOfDancers) * 1.5;
            }

            if (country == "Bulgaria" && season == "summer")
            {
                expenses = price * 0.95;
                charity = expenses * 0.75;
                perDancer = (expenses - charity) / numberOfDancers;
                Console.WriteLine($"Charity - {charity:f2}");
                Console.WriteLine($"Money per dancer - {perDancer:f2}");
            }
            else if (country == "Bulgaria" && season == "winter")
            {
                expenses = price * 0.92;
                charity = expenses * 0.75;
                perDancer = (expenses - charity) / numberOfDancers;
                Console.WriteLine($"Charity - {charity:f2}");
                Console.WriteLine($"Money per dancer - {perDancer:f2}");
            }
            else if (country == "Abroad" && season == "summer")
            {
                expenses = price * 0.90;
                charity = expenses * 0.75;
                perDancer = (expenses - charity) / numberOfDancers;
                Console.WriteLine($"Charity - {charity:f2}");
                Console.WriteLine($"Money per dancer - {perDancer:f2}");
            }
            else if (country == "Abroad" && season == "winter") 
            {
                expenses = price * 0.85;
                charity = expenses * 0.75;
                perDancer = (expenses - charity) / numberOfDancers;
                Console.WriteLine($"Charity - {charity:f2}");
                Console.WriteLine($"Money per dancer - {perDancer:f2}");
            }


        }
    }
}
