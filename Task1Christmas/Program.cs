using System;

namespace Task1Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int cloth = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            
            double expensesNoDiscount;
            double discountAmmount;
            double expenses;

            expensesNoDiscount = (paper * 5.80) + (cloth * 7.20) + (glue * 1.20);
            discountAmmount = expensesNoDiscount * (discount / 100);
            expenses = expensesNoDiscount - discountAmmount;

            Console.WriteLine($"{expenses:f3}");
        }
    }
}
