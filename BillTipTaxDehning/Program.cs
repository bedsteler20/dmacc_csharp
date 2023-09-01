/***************************************************************
* Name : Bill Tip Tax
* Author : Cameron Dehning
* Created : 089/01/2023
* Course : CIS 169 - C#
* Version : 1.0
* OS : Fedora 38 Workstation
* IDE : Visual Studio Code (Dotnet Core 7.0)
* Copyright : This is my own original work based on
* specifications issued by our instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.
***************************************************************/
namespace BillTipTax {
    class Program {
        public static void Main(string[] args) {
            const double TAX_RATE = 0.07;
            const double TIP_RATE = 0.20;
            double meal1;
            double meal2;
            double dessert1;
            double dessert2;

            try {
                Console.Write("Enter the price of the first meal: ");
                meal1 = double.Parse(Console.ReadLine()!);
            } catch (Exception) {
                Console.WriteLine("Input string was not in a correct format.");
                meal1 = 0;
            }

            try {
                Console.Write("Enter the price of the second meal: ");
                meal2 = double.Parse(Console.ReadLine()!);
            } catch (Exception) {
                Console.WriteLine("Input string was not in a correct format.");
                meal2 = 0;
            }

            try {
                Console.Write("Enter the price of the first dessert: ");
                dessert1 = double.Parse(Console.ReadLine()!);
            } catch (Exception) {
                Console.WriteLine("Input string was not in a correct format.");
                dessert1 = 0;
            }

            try {
                Console.Write("Enter the price of the second dessert: ");
                dessert2 = double.Parse(Console.ReadLine()!);
            } catch (Exception) {
                Console.WriteLine("Input string was not in a correct format.");
                dessert2 = 0;
            }

            double person1 = meal1 + dessert1;
            double person2 = meal2 + dessert2;
            double subtotal = person1 + person2;
            double tax = subtotal * TAX_RATE;
            double tip = subtotal * TIP_RATE;
            double total = subtotal + tip + tax;
            double perPerson = total / 2;


            Console.WriteLine($"========== Receipt ==========");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Tax: {tax:C}");
            Console.WriteLine($"Tip: {tip:C}");
            Console.WriteLine($"Total: {total:C}");
            Console.WriteLine($"Per person: {perPerson:C}");
            Console.WriteLine($"=============================");

        }
    }
}
