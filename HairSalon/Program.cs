using System;

namespace HairSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            double revenu = 0;
            string haircut;

            do
            {
                haircut = Console.ReadLine();

                if (haircut == "haircut mens")
                {
                    revenu += 15;
                }
                else if (haircut == "haircut ladies")
                {
                    revenu += 20;
                }
                else if (haircut == "haircut kids")
                {
                    revenu += 10;
                }
                else if (haircut == "color touch up")
                {
                    revenu += 20;
                }
                else if (haircut == "color full color")
                {
                    revenu += 30;
                }

            } while (haircut != "closed" || target == revenu);

            if (revenu == target)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {revenu}lv.");
            }
            else
            {
                double output = target - revenu;
                Console.WriteLine($"Target not reached! You need {output}lv. more.");
                Console.WriteLine($"Earned money: {revenu}lv.");
            }

        }
    }
}
